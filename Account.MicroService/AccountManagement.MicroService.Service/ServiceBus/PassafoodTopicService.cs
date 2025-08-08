using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using AccountManagement.FrameWork.Models;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace AccountManagement.MicroService.ServiceBus
{
    public class PassafoodTopicService : BackgroundService
    {
        private readonly IServiceScopeFactory factory;
        private IConfiguration configuration;

        public PassafoodTopicService( 
            IServiceScopeFactory factory, IConfiguration configuration)
        {
            this.factory = factory;
            this.configuration = configuration;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var connectionString = configuration.GetValue<string>("ServiceBus:ConnectionString");
            var topicName = configuration.GetValue<string>("ServiceBus:TopicName");

            var s1 = new SubscriptionClient(connectionString, topicName, "RIDER_ACTIVITY");
            s1.RegisterMessageHandler((m,t)=> {
                AddRiderActivity(m, t);
                return s1.CompleteAsync(m.SystemProperties.LockToken);
            },new MessageHandlerOptions(x => Task.CompletedTask) {
                 AutoComplete=false,
                 MaxConcurrentCalls=1
            });

            var s2 = new SubscriptionClient(connectionString, topicName, "RIDER_TRIPS_LOG");
            s2.RegisterMessageHandler((m, t) =>
            {
                UpdateRiderTrips(m, t);
                return s2.CompleteAsync(m.SystemProperties.LockToken);
            }
            , new MessageHandlerOptions(x => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });

            var s3 = new SubscriptionClient(connectionString, topicName, "CONSUMER_DELIVERY_COUNT");
            s3.RegisterMessageHandler((m, t) =>
            {
                UpdateConsumerDeliveryCount(m, t);
                return s3.CompleteAsync(m.SystemProperties.LockToken);
            } 
            , new MessageHandlerOptions(x => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });
             
            return Task.CompletedTask;
        }


        public Task AddRiderActivity(Message message, CancellationToken ctoken)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<RiderActivityPayload>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var _rider = new RiderActivityEntity();
                    _rider.Activity = data.Activity;
                    _rider.DateTimeLog = data.DateTimeLog;
                    _rider.Status = data.Status;
                    _rider.RiderId = data.RiderId;
                    _rider.Reference = data.Reference;
                    context.RiderActivities.Add(_rider);
                    context.SaveChanges();
                }
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.CompletedTask;
            } 
        }
        public   Task UpdateRiderTrips(Message message, CancellationToken ctoken)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<RideTripLogPayload>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var trip = context.RiderTripsLogs.FirstOrDefault(x => x.BookingId == data.BookingId);
                    if (trip == null) trip = new RiderTripsLog();
                    trip.BookingDate = data.BookingDate;
                    trip.BookingId = data?.BookingId;
                    trip.RiderGUID = data?.RiderGUID;
                    trip.Status = data?.Status;
                    if (trip.Id == 0)   context.RiderTripsLogs.Add(trip);
                    else context.RiderTripsLogs.Update(trip);

                    context.SaveChanges();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return Task.CompletedTask;

            }
        }

        public  Task UpdateConsumerDeliveryCount(Message message, CancellationToken ctoken)
        {

            try
            {
                var data = JsonConvert.DeserializeObject<ConsumerOrderCountPayload>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var consumer = context.ConsumerAccounts.FirstOrDefault(x => x.GUID == data.ConsumerId);
                    consumer.OrderCount = consumer.OrderCount + 1;
                    context.ConsumerAccounts.Update(consumer);
                    context.SaveChanges();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return Task.CompletedTask;
            }
        }

    public class RideTripLogPayload
    {
        public DateTime DateCreated { get; set; }
        public string BookingId { get; set; }
        public DateTime BookingDate { get; set; }
        public string Status { get; set; }
        public string RiderGUID { get; set; }
    }

    public class RiderActivityPayload
    {
        public string RiderId { get; set; }
        public string Reference { get; set; }
        public string Status { get; set; }
        public DateTime DateTimeLog { get; set; }
        public string Activity { get; set; }
    }

    public class ConsumerOrderCountPayload
    {
        public string ConsumerId { get; set; }
    }
  }
}

using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AccountManagement.Framework.Data;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;

namespace AccountManagement.MicroService.ServiceBus
{
    public class RatingService : BackgroundService
    {
        private readonly IServiceScopeFactory factory;
        private IConfiguration configuration;

        public RatingService(
            IServiceScopeFactory factory, IConfiguration configuration)
        {
            this.factory = factory;
            this.configuration = configuration;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var connectionString = configuration.GetValue<string>("ServiceBus:ConnectionString");
            var topicName = configuration.GetValue<string>("ServiceBus:RatingTopic");

            var consRider = new SubscriptionClient(connectionString, topicName, "consumer_rider");
            consRider.RegisterMessageHandler((m, t) => {
                ConsumerRider(m, t);
                return consRider.CompleteAsync(m.SystemProperties.LockToken);
            }, new MessageHandlerOptions(x => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });

            var consMerchant = new SubscriptionClient(connectionString, topicName, "consumer_merchant");
            consMerchant.RegisterMessageHandler((m, t) =>
            {
                ConsumerMerchant(m, t);
                return consMerchant.CompleteAsync(m.SystemProperties.LockToken);
            }
            , new MessageHandlerOptions(x => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });

            var rMerchant = new SubscriptionClient(connectionString, topicName, "rider_merchant");
            rMerchant.RegisterMessageHandler((m, t) =>
            {
                RiderMerchant(m, t);
                return rMerchant.CompleteAsync(m.SystemProperties.LockToken);
            }
            , new MessageHandlerOptions(x => Task.CompletedTask)
            {
                AutoComplete = false,
                MaxConcurrentCalls = 1
            });

            return Task.CompletedTask;
        }

        public Task ConsumerRider(Message message, CancellationToken ctoken)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<consumer_rider>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var rider = context.RiderAccounts.FirstOrDefault(x => x.GUID == data.RiderId);
                    rider.Rating += data.Rating;
                    rider.RatingCount += 1;
                    context.RiderAccounts.Update(rider);
                    context.SaveChanges();
                    return Task.CompletedTask;
                }
                return Task.CompletedTask;
            }
            catch (Exception ex)
            {
                return Task.CompletedTask;
            }
        }
        public Task ConsumerMerchant(Message message, CancellationToken ctoken)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<consumer_merchant>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var store = context.MerchantStores.FirstOrDefault(x => x.GUID == data.StoreId);
                    store.ConsumerRating += data.Rating;
                    store.ConsumerRatingCount += 1;
                    context.MerchantStores.Update(store);
                    context.SaveChanges();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return Task.CompletedTask;

            }
        }

        public Task RiderMerchant(Message message, CancellationToken ctoken)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<rider_merchant>(Encoding.UTF8.GetString(message.Body));
                using (var scope = factory.CreateScope())
                {
                    var context = scope.ServiceProvider.GetRequiredService<AccountDbContext>();
                    var store = context.MerchantStores.FirstOrDefault(x => x.GUID == data.StoreId);
                    store.RiderRating += data.Rating;
                    store.RiderRatingCount += 1;
                    context.MerchantStores.Update(store);
                    context.SaveChanges();
                    return Task.CompletedTask;
                }
            }
            catch (Exception)
            {
                return Task.CompletedTask;
            }
        }

        public class consumer_rider
        {
            public string RiderId { get; set; }
            public double Rating { get; set; }
        }
        public class consumer_merchant
        {
            public string StoreId { get; set; }
            public double Rating { get; set; }
        }

        public class rider_merchant
        {
            public string StoreId { get; set; }
            public double Rating { get; set; }
        }
    }
}

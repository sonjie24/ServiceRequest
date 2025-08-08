using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using AccountManagement.Framework.Data;
using AccountManagement.Framework.Models;
using AccountManagement.Framework.Core;
using AccountManagement.Framework.Core.Interfaces;
using AccountManagement.Framework.Core.Managers;
using Framework.Data.Repository;
using Microsoft.Azure.ServiceBus;
using AccountManagement.MicroService.ServiceBus;
using System.Threading.Tasks;
using AccountManagement.MicroService.Controllers.Publisher;

namespace AccountManagement.MicroService
{
    public class  AOtherInstaller : IInstaller
    {
        public AOtherInstaller()
        {

        }
        public void InstallService(IServiceCollection services, IConfiguration configuration)
        {

            // Database         
            services.AddTransient<Database>();
            services.AddTransient<UnitOfWork>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();

            //Dependncy Injection
            services.AddTransient<IGenericQueryManager, GenericQueryManager>();
            //services.AddScoped<IDeviceDetailsManager, DeviceDetailsManager>();

            services.AddScoped(typeof(IRiderTokenManager<RiderAccountEntity>), typeof(RiderTokenManger));
            services.AddScoped(typeof(IMerchantTokenManager<MerchantAccountEntity>), typeof(MerchantTokenManager));
            services.AddScoped(typeof(IAdminTokenManager<AdminAccountEntity>), typeof(AdminTokenManager));
            services.AddScoped(typeof(IConsumerTokenManager<ConsumerAccountEntity>), typeof(ConsumerTokenManager));

            services.AddScoped(typeof(IRiderAccoutManager<RiderAccountEntity>), typeof(RiderAccountManager));
            services.AddScoped(typeof(IMerchantAccountManager<MerchantAccountEntity>), typeof(MerchantAccountManager ));
            services.AddScoped(typeof(IMerchantStoreManager<MerchantStoreEntity>), typeof(MerchantStoreManager));
            services.AddScoped(typeof(IAdminAccountManager<AdminAccountEntity>), typeof(AdminAccountManager));
            services.AddScoped(typeof(IConsumerAccountManager<ConsumerAccountEntity>), typeof(ConsumerAccountManager));

            //Service Bus 

            //services.AddSingleton<ISubscriptionClient>(x => new SubscriptionClient(
            //    configuration.GetValue<string>("ServiceBus:ConnectionString"),
            //    configuration.GetValue<string>("ServiceBus:TopicName"),
            //    configuration.GetValue<string>("ServiceBus:SubscriptionName")));

            services.AddSingleton<ITopicClient>(x =>
                      new TopicClient(configuration.GetValue<string>("ServiceBus:ConnectionString")
                      , configuration.GetValue<string>("ServiceBus:TopicName")));

            services.AddSingleton<IPublisher, Publisher>();
            services.AddHostedService<PassafoodTopicService>();
            services.AddHostedService<RatingService>();

            //services.AddHostedService<ConsumerService>();

            //End Service Bus
            //var configurationOptions = new ConfigurationOptions
            //{
            //    EndPoints = { $"{configurationp.GetValue<string>("RedisConnection:Host")}:{configurationp.GetValue<int>("RedisConnection:Port")}" },
            //    Ssl = true,
            //    AbortOnConnectFail = false,
            //};

            //Redis Connection
            //services.AddTransient(typeof(ICacheService<>),typeof(AccountCacheService<>));
            //services.AddSingleton<IConnectionMultiplexer>(x =>
            //{
            //    return ConnectionMultiplexer.Connect(configuration.GetValue<string>("RedisConnection"));
            //});
            //End Redis Config

            //AutoMapper

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfileConfiguration());
            });
            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}

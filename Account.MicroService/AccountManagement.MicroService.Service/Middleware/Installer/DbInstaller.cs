using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using AccountManagement.Framework.Data;

namespace AccountManagement.MicroService
{
    public class DbInstaller : IInstaller
    {
        public void InstallService(IServiceCollection services, IConfiguration configuration )
        {

            services.AddDbContext<AccountDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("AccountConnection"), x => { x.UseNetTopologySuite(); }), ServiceLifetime.Scoped, ServiceLifetime.Scoped);
            //services.AddDbContext<AccountDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("LocalConnection"),x=> { x.UseNetTopologySuite(); }), ServiceLifetime.Scoped, ServiceLifetime.Scoped);

            //Migration
            //services.BuildServiceProvider().GetService<AccountDbContext>().Database.Migrate();

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

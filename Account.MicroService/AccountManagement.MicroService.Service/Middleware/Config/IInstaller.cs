using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AccountManagement.MicroService
{
    public  interface IInstaller
    {
        void InstallService(IServiceCollection services,IConfiguration configurationp);
    }
}

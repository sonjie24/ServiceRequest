using AccountManagement.MicroService.Controllers.Publisher;
using AccountManagement.MicroService.Hubs;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Azure.ServiceBus;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AccountManagement.MicroService
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.InstallServiceAssembly (Configuration);

            services.AddSignalR(options =>
            {
                options.EnableDetailedErrors = true;
            }).AddAzureSignalR(Configuration["SignalR:ConnectionString"]);

          
            //services.AddOptions();
            //services.AddMemoryCache();
            //services.Configure<IpRateLimitOptions>(Configuration.GetSection("IpRateLimiting"));
            //services.Configure<IpRateLimitPolicies>(Configuration.GetSection("IpRateLimitPolicies"));
            //services.AddInMemoryRateLimiting();
            //services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
            ////services.AddSingleton<IIpPolicyStore, DistributedCacheIpPolicyStore>();
            ////services.AddSingleton<IRateLimitCounterStore, DistributedCacheRateLimitCounterStore>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                //app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");

                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            //Addd User session

            app.UseSession();

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            var swaggerOptions = new SwaggerOptions();
            Configuration
                .GetSection(nameof(SwaggerOptions))
                .Bind(swaggerOptions);
            app
                .UseSwagger(Option =>
                {
                    Option.RouteTemplate = swaggerOptions.JsonRoute;
                });
            app
                .UseSwaggerUI(Option =>
                {
                    Option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
                    Option.DocExpansion(Swashbuckle.AspNetCore.SwaggerUI.DocExpansion.None);
                });

                     //CORS
                      app.UseCors(x => x
                       .WithOrigins("https://localhost:5004",
                       "https://localhost:5002",
                       "http://localhost:8080",
                       "https://localhost:8080",
                       "https://localhost:8081",
                       "http://localhost:8081",
                       "https://localhost:44354",
                       "https://localhost:44356",
                       "https://localhost:15672",
                       "https://merchant.passafood.co",
                       "https://admin.passafood.co",
                       "https://register.passafood.co", 
                       "https://pf-account-service.azurewebsites.net",
                       "https://pf-booking-service.azurewebsites.net",
                       "https://pf-other-service.azurewebsites.net",
                       "https://pf-product-service.azurewebsites.net")
                       .AllowAnyHeader()
                       .AllowAnyMethod()
                       .AllowCredentials());

            //app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            app.UseRouting();

            // app.UseAuthorization();
            //Authentication
            app.UseAuthentication();

            //app.UseIpRateLimiting();
            app
                .UseEndpoints(endpoints =>
                {
                    endpoints
                        .MapControllerRoute("default",
                        "{controller=Home}/{action=Index}");

                        endpoints.MapHub<RiderHub>("/rider-hub");
                        endpoints.MapHub<AdminHub>("/admin-hub");
                        endpoints.MapHub<ConsumerHub>("/consumer-hub");
                        endpoints.MapHub<MerchantAccountHub>("/merchant-user-hub");
                        endpoints.MapHub<MerchantStoreHub>("/merchant-store-hub");

                });
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.PlatformAbstractions;
using AccountManagement.Framework.Core;

namespace AccountManagement.MicroService
{
    public class MvcInstaller : IInstaller
    {
        public MvcInstaller()
        {

        }
        public void InstallService(IServiceCollection services, IConfiguration configuration )
        {
             //Session
            services.AddSession(options => {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
            });

   
            //Jwt Configuration
            var jwtSettings = new JwtSettings();
            configuration.Bind(key: nameof(jwtSettings), jwtSettings);
            services.AddSingleton(jwtSettings);

            //RabbitConnectionFactory
            var rabbitConnection  = new RabbitConnectionFactory();
            configuration.Bind(key: nameof(RabbitConnectionFactory), rabbitConnection);
            services.AddSingleton(rabbitConnection);
           
            //Jwt Information
            var JwtInformation = new JwtInformation();
            configuration.Bind(key: nameof(JwtInformation), JwtInformation);
            services.AddSingleton(JwtInformation);

            //var tokenValidationParameters = new TokenValidationParameters
            //{
            //    SaveSigninToken = true,
            //    ValidateActor = true,
            //    ValidateIssuer = true,
            //    ValidateAudience = true,
            //    ValidateLifetime = true,
            //    ValidateIssuerSigningKey = true,
            //    ValidIssuer = Configuration["Jwt:Issuer"],
            //    ValidAudience = Configuration["Jwt:Audience"],
            //    IssuerSigningKey = new SymmetricSecurityKey(key),
            //    // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
            //    ClockSkew = TimeSpan.Zero
            //};

            //    ClockSkew=TimeSpan.Zero,
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key: Encoding.ASCII.GetBytes(jwtSettings.SecretKey)),
                ValidateIssuer = false,
                ValidateAudience = false,
                RequireExpirationTime = true,
                ValidateLifetime =   true,
            };

            //services.AddTransient<TokenValidationParameters>);

            services.AddSingleton(tokenValidationParameters); 

            //Policy
            services.AddAuthorization(options =>
            {
                options.AddPolicy("SuperUserPolicy", policy =>
                    policy.RequireAssertion(context =>
                        context.User.HasClaim(c => c.Type == "roledescription" && c.Value == "Super Admin")));
                options.AddPolicy("ClientPolicy", policy =>
                    policy.RequireAssertion(context =>
                        context.User.HasClaim(c => c.Type == "roledescription" && c.Value == "CLient")));
                options.AddPolicy("ProviderPolicy", policy =>
                    policy.RequireAssertion(context =>
                        context.User.HasClaim(c => c.Type == "roledescription" && c.Value == "Provider")));
                options.AddPolicy("AdminPolicy", policy =>
                    policy.RequireAssertion(context =>
                        context.User.HasClaim(c => c.Type == "roledescription" && c.Value == "Admin")));
            });

            services.AddAuthentication(opt =>
            {
                opt.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultSignInScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultSignOutScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                opt.DefaultForbidScheme = JwtBearerDefaults.AuthenticationScheme;
            })

            //specify how incoming token is validated

            .AddJwtBearer(options =>
            {
                options.SaveToken = true;
                options.RequireHttpsMetadata = false;  // Development Purpose, set this to 'true' in production/staging
                options.TokenValidationParameters = tokenValidationParameters;
                options.Events = new JwtBearerEvents()
                {
                    OnTokenValidated = context =>
                    {
                        Console.WriteLine("OnTokenValidated: " + context.SecurityToken);
                        return Task.CompletedTask;
                    },
                    OnAuthenticationFailed = context =>
                    {
                        Console.WriteLine("OnAuthenticationFailed: " + context.Exception.Message);
                        return Task.CompletedTask;
                    }
                };
            });


            //Add MVC  
            services.AddMvc(
                options =>
                    {
                        var policy = new AuthorizationPolicyBuilder()
                                .RequireAuthenticatedUser()
                                .AddAuthenticationSchemes(JwtBearerDefaults.AuthenticationScheme)
                                .Build();

                        options.Filters.Add(new AuthorizeFilter(policy));
                    }
            )
            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);


            // Add Swagger 
            services.AddSwaggerGen(config =>
            {
                config.SwaggerDoc(JwtInformation.Version, new OpenApiInfo
                {
                      
                    Version = JwtInformation.Version,
                    Title = JwtInformation.Tittle,
                    Description = JwtInformation.Description, 
                    TermsOfService = new Uri(JwtInformation.TermsOfService),
                    Contact = new OpenApiContact
                    {
                        Name = JwtInformation.ContactName,
                        Email = JwtInformation.ContactEmail
                    },
                    License = new OpenApiLicense
                    {
                        Name = JwtInformation.LicenseName,
                        Url = new Uri(JwtInformation.LicenseUrl),
                    }
                });


                config.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description =
                    "JWT Authorization header using the Bearer scheme. \r\n\r\n Enter 'Bearer' [space] and then your token in the text input below.\r\n\r\nExample: \"Bearer 12345abcdef...\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                config.AddSecurityRequirement(new OpenApiSecurityRequirement()
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "JWT",
                            Name = "Bearer",
                            In = ParameterLocation.Header,

                        },
                        new List<string>()
                    }
                });              

                config.TagActionsBy(api => new[] { api.GroupName });
                config.DocInclusionPredicate((name, api) => true);

                //// Set the comments path for the Swagger JSON and UI.
                var basePath = PlatformServices.Default.Application.ApplicationBasePath;
                var xmlPath = Path.Combine(basePath,   "AccountManagement.MicroService.App.xml");
                config.IncludeXmlComments(xmlPath);

            });
        }
    }
}

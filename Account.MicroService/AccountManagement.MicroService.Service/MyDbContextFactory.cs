using System;
using System.IO;
using AccountManagement.Framework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AccountManagement.MicroService
{
    public class MyDbContextFactory : IDesignTimeDbContextFactory<AccountDbContext>
    {

        AccountDbContext IDesignTimeDbContextFactory<AccountDbContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.Production.json")
                .Build();

            var builder = new DbContextOptionsBuilder<AccountDbContext>();
            var connectionString = configuration.GetConnectionString("AccountConnection");
            builder.UseSqlServer(connectionString, x => x.UseNetTopologySuite());
            return new AccountDbContext(builder.Options);

        }
    }
}
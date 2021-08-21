using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Clients.EntityFrameworkCore
{
    public class ClientsHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<ClientsHttpApiHostMigrationsDbContext>
    {
        public ClientsHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<ClientsHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Clients"));

            return new ClientsHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}

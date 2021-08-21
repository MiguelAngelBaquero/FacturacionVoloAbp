using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace VentasProductos.EntityFrameworkCore
{
    public class VentasProductosHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<VentasProductosHttpApiHostMigrationsDbContext>
    {
        public VentasProductosHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<VentasProductosHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("VentasProductos"));

            return new VentasProductosHttpApiHostMigrationsDbContext(builder.Options);
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

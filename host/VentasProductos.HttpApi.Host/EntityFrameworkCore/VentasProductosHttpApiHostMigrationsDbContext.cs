using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace VentasProductos.EntityFrameworkCore
{
    public class VentasProductosHttpApiHostMigrationsDbContext : AbpDbContext<VentasProductosHttpApiHostMigrationsDbContext>
    {
        public VentasProductosHttpApiHostMigrationsDbContext(DbContextOptions<VentasProductosHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureVentasProductos();
        }
    }
}

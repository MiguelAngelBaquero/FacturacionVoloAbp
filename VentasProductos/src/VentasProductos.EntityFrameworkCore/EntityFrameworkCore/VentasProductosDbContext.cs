using Microsoft.EntityFrameworkCore;
using VentasProductos.Products;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace VentasProductos.EntityFrameworkCore
{
    [ConnectionStringName(VentasProductosDbProperties.ConnectionStringName)]
    public class VentasProductosDbContext : AbpDbContext<VentasProductosDbContext>, IVentasProductosDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Product> Products { get; set; }

        public VentasProductosDbContext(DbContextOptions<VentasProductosDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureVentasProductos();
        }
    }
}
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace VentasProductos.EntityFrameworkCore
{
    [ConnectionStringName(VentasProductosDbProperties.ConnectionStringName)]
    public interface IVentasProductosDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}
using VentasProductos.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VentasProductos
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(VentasProductosEntityFrameworkCoreTestModule)
        )]
    public class VentasProductosDomainTestModule : AbpModule
    {
        
    }
}

using Volo.Abp.Modularity;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosApplicationModule),
        typeof(VentasProductosDomainTestModule)
        )]
    public class VentasProductosApplicationTestModule : AbpModule
    {

    }
}

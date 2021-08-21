using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace VentasProductos
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(VentasProductosDomainSharedModule)
    )]
    public class VentasProductosDomainModule : AbpModule
    {

    }
}

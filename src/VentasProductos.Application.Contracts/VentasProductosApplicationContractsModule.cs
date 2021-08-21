using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class VentasProductosApplicationContractsModule : AbpModule
    {

    }
}

using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class VentasProductosConsoleApiClientModule : AbpModule
    {
        
    }
}

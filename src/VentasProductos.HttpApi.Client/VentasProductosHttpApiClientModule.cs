using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class VentasProductosHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "VentasProductos";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(VentasProductosApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Clients
{
    [DependsOn(
        typeof(ClientsApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ClientsHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "Clients";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ClientsApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}

using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Clients
{
    [DependsOn(
        typeof(ClientsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ClientsConsoleApiClientModule : AbpModule
    {
        
    }
}

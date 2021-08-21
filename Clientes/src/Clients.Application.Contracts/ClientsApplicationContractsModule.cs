using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Clients
{
    [DependsOn(
        typeof(ClientsDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class ClientsApplicationContractsModule : AbpModule
    {

    }
}

using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace Clients
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(ClientsDomainSharedModule)
    )]
    public class ClientsDomainModule : AbpModule
    {

    }
}

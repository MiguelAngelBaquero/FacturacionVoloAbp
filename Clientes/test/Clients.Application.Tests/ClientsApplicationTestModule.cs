using Volo.Abp.Modularity;

namespace Clients
{
    [DependsOn(
        typeof(ClientsApplicationModule),
        typeof(ClientsDomainTestModule)
        )]
    public class ClientsApplicationTestModule : AbpModule
    {

    }
}

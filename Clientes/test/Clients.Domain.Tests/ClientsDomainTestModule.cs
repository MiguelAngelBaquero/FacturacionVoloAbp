using Clients.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Clients
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ClientsEntityFrameworkCoreTestModule)
        )]
    public class ClientsDomainTestModule : AbpModule
    {
        
    }
}

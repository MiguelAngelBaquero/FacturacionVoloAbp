using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Clients.EntityFrameworkCore
{
    [ConnectionStringName(ClientsDbProperties.ConnectionStringName)]
    public interface IClientsDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}
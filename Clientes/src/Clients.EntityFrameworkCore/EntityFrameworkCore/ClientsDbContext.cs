using Clients.Clients;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Clients.EntityFrameworkCore
{
    [ConnectionStringName(ClientsDbProperties.ConnectionStringName)]
    public class ClientsDbContext : AbpDbContext<ClientsDbContext>, IClientsDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<Client> Clients  { get; set; }

        public ClientsDbContext(DbContextOptions<ClientsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureClients();
        }
    }
}
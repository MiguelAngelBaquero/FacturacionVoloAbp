using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Clients.EntityFrameworkCore
{
    public class ClientsHttpApiHostMigrationsDbContext : AbpDbContext<ClientsHttpApiHostMigrationsDbContext>
    {
        public ClientsHttpApiHostMigrationsDbContext(DbContextOptions<ClientsHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureClients();
        }
    }
}

using Clients.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Clients.Clients
{
    public class ClientRepository : EfCoreRepository<ClientsDbContext, Client, int>, IClientRepository
    {
        public ClientRepository(IDbContextProvider<ClientsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Client> FindClientByIdAsync(string identification)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(c => c.Identification == identification);
        }
    }
}

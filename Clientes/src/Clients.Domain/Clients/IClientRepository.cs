using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace Clients.Clients
{
    public interface IClientRepository : IRepository<Client, int>
    {
        Task<Client> FindClientByIdAsync(string identification);
    }
}

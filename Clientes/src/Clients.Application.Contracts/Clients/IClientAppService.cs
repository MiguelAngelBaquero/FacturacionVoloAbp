using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Clients.Clients
{
    public interface IClientAppService : IApplicationService
    {
        Task<ClientDto> CreateClientAsync(CreateClientDto input);
    }
}

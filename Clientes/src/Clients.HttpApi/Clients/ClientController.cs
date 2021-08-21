using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Volo.Abp;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace Clients.Clients
{
    [RemoteService]
    [Route("api/clients")]
    public class ClientController : ClientsController, IClientAppService
    {
        private readonly IClientAppService _clientAppService;

        public ClientController(IClientAppService clientAppService)
        {
            _clientAppService = clientAppService;
        }

        [HttpPost]
        [Route("create")]
        public Task<ClientDto> CreateClientAsync(CreateClientDto input)
        {
            return _clientAppService.CreateClientAsync(input);
        }


    }
}

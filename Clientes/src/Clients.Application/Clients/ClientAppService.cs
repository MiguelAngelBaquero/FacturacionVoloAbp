using System;
using System.Threading.Tasks;

namespace Clients.Clients
{
    public class ClientAppService : ClientsAppService, IClientAppService
    {
        private readonly IClientRepository _clientRepository;
        private readonly ClientManager _clientManager;

        public ClientAppService(ClientManager clientManager, IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
            _clientManager = clientManager;
        }

        public async Task<ClientDto> CreateClientAsync(CreateClientDto input)
        {
            var client = await _clientManager.CreateClientAsync(
                input.Identification, 
                input.Lastname, 
                input.FirstName,
                input.Birthdate,
                input.Gender,
                input.MobileNumber);
            return ObjectMapper.Map<Client, ClientDto>(client);
        }

        public async Task DeleteClientAsync(string identification)
        {
            var id = Int32.Parse(identification);
            await _clientRepository.DeleteAsync(id);
        }

        public async Task<ClientDto> GetAsync(string identification)
        {
            var id = Int32.Parse(identification);
            var client = await _clientRepository.GetAsync(id);
            return ObjectMapper.Map<Client, ClientDto>(client);
        }
    }
}

using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace Clients.Clients
{
    public class ClientManager : DomainService
    {
        private readonly IClientRepository _clientRepository;

        public ClientManager(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<Client> CreateClientAsync(
            [NotNull] string identification,
            [NotNull] string lastname,
            [NotNull] string firstname,
            [NotNull] DateTime birthdate,
            [CanBeNull] string mobilenumber,
            [CanBeNull] string email)
        {
            var existingClient = await _clientRepository.FindClientByIdAsync(identification);
            if (existingClient == null)
            {
                var client = new Client(
                    identification,
                    lastname,
                    firstname,
                    birthdate,
                    mobilenumber,
                    email);
                await _clientRepository.InsertAsync(client);
                return client;
            }
            return existingClient;

        }

        public async Task<Client> UpdateClientAsync(
        [NotNull] string identification,
        [NotNull] string lastname,
        [NotNull] string firstname,
        [NotNull] DateTime birthdate,
        [CanBeNull] string mobilenumber,
        [CanBeNull] string email)
        {
            var existingClient = await _clientRepository.FindClientByIdAsync(identification);
            existingClient.Identification = identification;
            existingClient.Lastname = lastname;
            existingClient.FirstName = firstname;
            existingClient.Birthdate = birthdate;
            existingClient.MobileNumber = mobilenumber;
            existingClient.Email = email;
            return existingClient;
        }
    }
}
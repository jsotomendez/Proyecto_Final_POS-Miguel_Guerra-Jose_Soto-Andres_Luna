using Proyecto_Final.Domain.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Application.Client
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetAsync()
        {
            var clients = await _clientRepository.GetAsync();

            if (clients == null || !clients.Any())
            {
                return new List<Client>();
            }
            return clients;
        }

        public async Task<Client> GetByIdAsync(Guid clientId)
        {
            var currentCLient = await _clientRepository.GetByIdAsync(clientId);
            return currentCLient ?? throw new Exception($"Id {clientId} NOT FOUND");
        }

        public async Task SaveAsync(Client client)
        {
            await _clientRepository.SaveAsync(client);
        }
    }
}

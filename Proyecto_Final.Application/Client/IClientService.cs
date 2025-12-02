using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_Final.Domain;
using Proyecto_Final.Domain.Client;

namespace Proyecto_Final.Application.Client
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAsync();
        Task<Client> GetByIdAsync(Guid clientId);
        Task SaveAsync(Client client);
    }
}

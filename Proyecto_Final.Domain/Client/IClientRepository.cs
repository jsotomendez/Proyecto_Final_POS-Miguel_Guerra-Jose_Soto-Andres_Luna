using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Client
{
    public interface IClientRepository{
        Task<IEnumerable<Client>> GetAsync();
        Task<Client> GetByIdAsync(Guid clientId);
        Task SaveAsync(Client client);
    }
}

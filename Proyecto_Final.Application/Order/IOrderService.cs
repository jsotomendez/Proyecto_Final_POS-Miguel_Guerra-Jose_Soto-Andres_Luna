using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Application.Order
{
    public interface IOrderService
    {
        Task<IEnumerable<Order>> GetAsync();
        Task<Order> GetByAsync(Guid id);
        Task SaveAsync(Order order);
    }
}

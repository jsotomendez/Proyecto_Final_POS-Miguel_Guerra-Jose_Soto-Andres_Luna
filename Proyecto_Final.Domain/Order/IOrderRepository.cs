using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Order
{
    public interface IOrderRepository{
        Task<IEnumerable<Order>> GetAsync();
        Task<Order> GetByIdAsync(Guid orderId);
        Task SaveAsync(Order order);
    }
}

using Proyecto_Final.Domain.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Application.Order
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repositoryOrder;

        public OrderService(IOrderRepository repositoryOrder)
        {
            _repositoryOrder = repositoryOrder;
        }

        public async Task<IEnumerable<Order>> GetAsync() => await _repositoryOrder.GetAsync();

        public async Task<Order> GetByAsync(Guid orderid)
        {
            var currentOrder = await _repositoryOrder.GetByIdAsync(orderid);
            return currentOrder ?? throw new Exception($"Id {orderid} NOT FOUND");
        }

        public async Task SaveAsync(Order order)
        {
            await _repositoryOrder.SaveAsync(order);

        }
    }
}

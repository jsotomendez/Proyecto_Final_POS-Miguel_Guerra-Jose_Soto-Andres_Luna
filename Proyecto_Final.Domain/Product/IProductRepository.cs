using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Domain.Product
{
    public interface IProductRepository{
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetByIdAsync(Guid productId);
        Task SaveAsync(Product product);
    }
}

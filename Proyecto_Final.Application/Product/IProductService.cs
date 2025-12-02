using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Application.Product
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAsync();
        Task<Product> GetByIdAsync(Guid productId);

        Task SaveAsync(Product product);
    }
}

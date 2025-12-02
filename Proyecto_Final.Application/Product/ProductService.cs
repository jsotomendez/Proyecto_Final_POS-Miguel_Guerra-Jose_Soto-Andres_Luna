using Proyecto_Final.Domain.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Application.Product
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _ProductRepository;

        public ProductService(IProductRepository repositoryProduct)
        {
            _ProductRepository = repositoryProduct;
        }

        public async Task<IEnumerable<Product>> GetAsync()
        {
            try
            {
                var products = await _ProductRepository.GetAsync();

                if (products == null || !products.Any())
                {
                    // Aquí puedes lanzar una excepción específica o manejar de alguna otra manera
                    throw new InvalidOperationException("Empty list.");
                }

                return products;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió una excepción: {ex.Message}");

                var products = await _ProductRepository.GetAsync();
                return products;
            }
        }

        public async Task<Product> GetByIdAsync(Guid productId)
        {
            var currentProduct = await _ProductRepository.GetByIdAsync(productId);
            return currentProduct ?? throw new Exception($"Id {productId} NOT FOUND");
        }

        public async Task SaveAsync(Product product)
        {
            await _ProductRepository.SaveAsync(product);
        }
    }
}

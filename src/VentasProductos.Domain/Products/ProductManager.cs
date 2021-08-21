using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Services;

namespace VentasProductos.Products
{
    public class ProductManager : DomainService
    {
        private readonly IProductRepository _productRepository;

        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> CreateProductAsync(
            [NotNull] string code,
            [NotNull] string name,
            [NotNull] float price)
        {
            var existingProduct = await _productRepository.FindProductByCodeAsync(code);
            if(existingProduct != null)
            {
                var product = new Product(code, name, price);
                await _productRepository.InsertAsync(product);
                return product;
            }
            return existingProduct;
        }

    }
}

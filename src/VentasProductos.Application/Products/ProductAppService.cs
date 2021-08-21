using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VentasProductos.Products
{
    public class ProductAppService : VentasProductosAppService, IProductAppService
    {
        private readonly ProductManager _productManager;

        public ProductAppService(ProductManager productManager)
        {
            _productManager = productManager;
        }

        public async Task<ProductDto> CreateProductAsync(string code, string name, float price)
        {
            var product = await _productManager.CreateProductAsync(code, name, price);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }
    }
}

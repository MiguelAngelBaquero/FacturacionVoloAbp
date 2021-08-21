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

        public async Task<ProductDto> CreateProductAsync(CreateProductDto input)
        {
            var product = await _productManager.CreateProductAsync(input.Code, input.Name, input.Price);
            return ObjectMapper.Map<Product, ProductDto>(product);
        }
    }
}

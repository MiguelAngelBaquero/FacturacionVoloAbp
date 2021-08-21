using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace VentasProductos.Products
{
    [RemoteService]
    [Route("api/products")]
    public class ProductController : VentasProductosController, IProductAppService
    {

        private readonly IProductAppService _productAppService;

        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ProductDto> CreateProductAsync(string code, string name, float price)
        {
            return await _productAppService.CreateProductAsync(code, name, price);
        }

    }
}

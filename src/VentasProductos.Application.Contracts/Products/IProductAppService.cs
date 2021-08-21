using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace VentasProductos.Products
{
    public interface IProductAppService : IApplicationService
    {
        Task<ProductDto> CreateProductAsync(string code, string name, float price);
    }
}

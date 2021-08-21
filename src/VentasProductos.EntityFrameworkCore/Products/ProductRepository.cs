using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VentasProductos.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace VentasProductos.Products
{
    public class ProductRepository :
        EfCoreRepository<VentasProductosDbContext, Product, int>,
        IProductRepository
    {
        public ProductRepository(IDbContextProvider<VentasProductosDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Product> FindProductByCodeAsync(string code)
        {
            var dbSet = await GetDbSetAsync();
            return await dbSet.FirstOrDefaultAsync(product => product.Code == code);
        }
    }
}

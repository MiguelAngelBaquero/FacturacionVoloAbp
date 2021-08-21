using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace VentasProductos.Products
{
    public interface IProductRepository : IRepository<Product, int>
    {
        Task<Product> FindProductByCodeAsync(string code);
    }
}

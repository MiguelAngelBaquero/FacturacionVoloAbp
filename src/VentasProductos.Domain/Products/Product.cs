using System.Collections.Generic;
using VentasProductos.Sells;
using Volo.Abp.Domain.Entities.Auditing;

namespace VentasProductos.Products
{
    public class Product : FullAuditedAggregateRoot<int>
    {

        public Product(string code, string name, float price)
        {
            Code = code;
            Name = name;
            Price = price;
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public List<SellDetail> SellDatails { get; set; }
    }
}

using VentasProductos.Products;
using Volo.Abp.Domain.Entities;

namespace VentasProductos.Sells
{
    public class SellDetail : Entity<int>
    {
        public int ProductId { get; set; }
        public int SellId { get; set; }
        public string ProductCode { get; set; }
        public int Quantity { get; set; }
        public float UnitPrice { get; set; }
        public float Amount { get; set; }

        public SellDetail(int productId, int sellId)
        {
            ProductId = productId;
            SellId = sellId;
            Quantity = 1;

        }
    }

}

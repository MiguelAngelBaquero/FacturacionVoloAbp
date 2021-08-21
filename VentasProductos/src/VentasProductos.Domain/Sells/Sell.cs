using System.Collections.Generic;
using Volo.Abp.Domain.Entities.Auditing;

namespace VentasProductos.Sells
{
    public class Sell : FullAuditedAggregateRoot<int>
    {

        public string Identification { get; set; }
        public float SubTotal { get; set; }
        public float Tax { get; set; }
        public float Total { get; set; }
        public List<SellDetail> SellDetails { get; set; }

        public Sell(string identification, float subTotal)
        {
            var tax = subTotal * 0.12f;
            Identification = identification;
            SubTotal = subTotal;
            Tax = tax;
            Total = subTotal + tax;
        }

    }
}

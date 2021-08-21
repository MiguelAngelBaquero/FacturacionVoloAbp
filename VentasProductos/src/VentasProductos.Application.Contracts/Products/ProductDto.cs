using Volo.Abp.Application.Dtos;

namespace VentasProductos.Products
{
    public class ProductDto : AuditedEntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
    }
}
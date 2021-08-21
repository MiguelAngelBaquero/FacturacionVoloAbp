using AutoMapper;
using VentasProductos.Products;

namespace VentasProductos
{
    public class VentasProductosApplicationAutoMapperProfile : Profile
    {
        public VentasProductosApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Product, ProductDto>();
        }
    }
}
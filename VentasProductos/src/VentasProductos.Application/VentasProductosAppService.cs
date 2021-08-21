using VentasProductos.Localization;
using Volo.Abp.Application.Services;

namespace VentasProductos
{
    public abstract class VentasProductosAppService : ApplicationService
    {
        protected VentasProductosAppService()
        {
            LocalizationResource = typeof(VentasProductosResource);
            ObjectMapperContext = typeof(VentasProductosApplicationModule);
        }
    }
}

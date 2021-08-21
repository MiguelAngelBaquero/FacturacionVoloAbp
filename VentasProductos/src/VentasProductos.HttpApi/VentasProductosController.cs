using VentasProductos.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace VentasProductos
{
    public abstract class VentasProductosController : AbpController
    {
        protected VentasProductosController()
        {
            LocalizationResource = typeof(VentasProductosResource);
        }
    }
}

using Localization.Resources.AbpUi;
using VentasProductos.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class VentasProductosHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(VentasProductosHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<VentasProductosResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}

using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace VentasProductos
{
    [DependsOn(
        typeof(VentasProductosDomainModule),
        typeof(VentasProductosApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class VentasProductosApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<VentasProductosApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<VentasProductosApplicationModule>(validate: true);
            });
        }
    }
}

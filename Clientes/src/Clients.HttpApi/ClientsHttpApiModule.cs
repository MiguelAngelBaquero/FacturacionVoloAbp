using Localization.Resources.AbpUi;
using Clients.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Clients
{
    [DependsOn(
        typeof(ClientsApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ClientsHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(ClientsHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ClientsResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}

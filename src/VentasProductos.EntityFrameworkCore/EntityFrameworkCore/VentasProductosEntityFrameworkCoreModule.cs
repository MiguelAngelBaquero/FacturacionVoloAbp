using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace VentasProductos.EntityFrameworkCore
{
    [DependsOn(
        typeof(VentasProductosDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class VentasProductosEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<VentasProductosDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}
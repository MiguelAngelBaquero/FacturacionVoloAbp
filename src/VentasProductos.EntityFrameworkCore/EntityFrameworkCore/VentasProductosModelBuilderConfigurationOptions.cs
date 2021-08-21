using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace VentasProductos.EntityFrameworkCore
{
    public class VentasProductosModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public VentasProductosModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
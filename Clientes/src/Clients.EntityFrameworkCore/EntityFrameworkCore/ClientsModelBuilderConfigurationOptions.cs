using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Clients.EntityFrameworkCore
{
    public class ClientsModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public ClientsModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}
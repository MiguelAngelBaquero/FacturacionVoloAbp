using Clients.Localization;
using Volo.Abp.Application.Services;

namespace Clients
{
    public abstract class ClientsAppService : ApplicationService
    {
        protected ClientsAppService()
        {
            LocalizationResource = typeof(ClientsResource);
            ObjectMapperContext = typeof(ClientsApplicationModule);
        }
    }
}

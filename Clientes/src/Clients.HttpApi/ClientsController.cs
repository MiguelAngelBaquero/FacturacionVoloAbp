using Clients.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Clients
{
    public abstract class ClientsController : AbpController
    {
        protected ClientsController()
        {
            LocalizationResource = typeof(ClientsResource);
        }
    }
}

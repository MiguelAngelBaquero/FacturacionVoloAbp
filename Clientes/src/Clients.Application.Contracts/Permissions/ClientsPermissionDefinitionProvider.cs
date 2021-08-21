using Clients.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Clients.Permissions
{
    public class ClientsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ClientsPermissions.GroupName, L("Permission:Clients"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ClientsResource>(name);
        }
    }
}
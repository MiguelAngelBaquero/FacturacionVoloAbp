using VentasProductos.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace VentasProductos.Permissions
{
    public class VentasProductosPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(VentasProductosPermissions.GroupName, L("Permission:VentasProductos"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<VentasProductosResource>(name);
        }
    }
}
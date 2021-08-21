using Volo.Abp.Reflection;

namespace VentasProductos.Permissions
{
    public class VentasProductosPermissions
    {
        public const string GroupName = "VentasProductos";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(VentasProductosPermissions));
        }
    }
}
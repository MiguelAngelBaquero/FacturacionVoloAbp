using Volo.Abp.Reflection;

namespace Clients.Permissions
{
    public class ClientsPermissions
    {
        public const string GroupName = "Clients";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ClientsPermissions));
        }
    }
}
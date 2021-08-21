namespace Clients
{
    public static class ClientsDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = "clients";

        public const string ConnectionStringName = "Clients";
    }
}

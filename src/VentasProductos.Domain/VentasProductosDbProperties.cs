namespace VentasProductos
{
    public static class VentasProductosDbProperties
    {
        public static string DbTablePrefix { get; set; } = "";

        public static string DbSchema { get; set; } = "invoice";

        public const string ConnectionStringName = "VentasProductos";
    }
}

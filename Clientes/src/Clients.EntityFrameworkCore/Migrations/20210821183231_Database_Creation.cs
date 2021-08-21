using Microsoft.EntityFrameworkCore.Migrations;

namespace Clients.Migrations
{
    public partial class Database_Creation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "clients");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Clients",
                newSchema: "clients");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Clients",
                schema: "clients",
                newName: "Clients");
        }
    }
}

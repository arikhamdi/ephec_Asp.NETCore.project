using Microsoft.EntityFrameworkCore.Migrations;

namespace projetWeb.Migrations
{
    public partial class CorrectId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstablishementID",
                table: "Establishment",
                newName: "EstablishmentID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EstablishmentID",
                table: "Establishment",
                newName: "EstablishementID");
        }
    }
}

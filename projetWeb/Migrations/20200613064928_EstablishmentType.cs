using Microsoft.EntityFrameworkCore.Migrations;

namespace projetWeb.Migrations
{
    public partial class EstablishmentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Establishment");

            migrationBuilder.AddColumn<string>(
                name: "EstablishmentType",
                table: "Establishment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstablishmentType",
                table: "Establishment");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Establishment",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

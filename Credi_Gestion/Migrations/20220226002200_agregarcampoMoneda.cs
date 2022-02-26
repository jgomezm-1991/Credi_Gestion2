using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class agregarcampoMoneda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Moneda",
                table: "Prestamo",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Moneda",
                table: "Prestamo");
        }
    }
}

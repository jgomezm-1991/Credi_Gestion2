using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class Agregarcamposcliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Cliente",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Cliente");
        }
    }
}

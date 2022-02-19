using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Prestamo",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Saldo",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Sexo",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "UsuarioRe",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCliente",
                table: "Cliente",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "IdCliente",
                table: "Cliente",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Apellidos",
                table: "Cliente",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Cliente",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Cliente",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IdUsuario",
                table: "Cliente",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "IdCliente");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "IdCliente",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IdCliente",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Apellidos",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Cliente");

            migrationBuilder.AlterColumn<string>(
                name: "NombreCliente",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Cliente",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<decimal>(
                name: "Prestamo",
                table: "Cliente",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Saldo",
                table: "Cliente",
                type: "decimal(12, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Sexo",
                table: "Cliente",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioRe",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Prestamo_Cliente_ClienteId",
                table: "Prestamo",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

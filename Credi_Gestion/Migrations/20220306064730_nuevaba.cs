using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class nuevaba : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Prestamo_IdPrestamo",
                table: "Pagos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos");

            migrationBuilder.DropIndex(
                name: "IX_Pagos_IdPrestamo",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "Id_Pago",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrestamo",
                table: "Pagos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdPago",
                table: "Pagos",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos",
                column: "IdPago");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos");

            migrationBuilder.DropColumn(
                name: "IdPago",
                table: "Pagos");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrestamo",
                table: "Pagos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Id_Pago",
                table: "Pagos",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pagos",
                table: "Pagos",
                column: "Id_Pago");

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdPrestamo",
                table: "Pagos",
                column: "IdPrestamo");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Prestamo_IdPrestamo",
                table: "Pagos",
                column: "IdPrestamo",
                principalTable: "Prestamo",
                principalColumn: "IdPrestamo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

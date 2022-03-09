using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class agregarcampo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pago_Prestamo_IdPrestamo",
                table: "Pago");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrestamo",
                table: "Pago",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pago_Prestamo_IdPrestamo",
                table: "Pago",
                column: "IdPrestamo",
                principalTable: "Prestamo",
                principalColumn: "IdPrestamo",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pago_Prestamo_IdPrestamo",
                table: "Pago");

            migrationBuilder.AlterColumn<int>(
                name: "IdPrestamo",
                table: "Pago",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Pago_Prestamo_IdPrestamo",
                table: "Pago",
                column: "IdPrestamo",
                principalTable: "Prestamo",
                principalColumn: "IdPrestamo",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

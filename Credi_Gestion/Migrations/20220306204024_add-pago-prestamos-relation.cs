using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class addpagoprestamosrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pago",
                columns: table => new
                {
                    IdPago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoPagado = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    FechaPago = table.Column<DateTime>(nullable: false),
                    Saldo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    UsuarioRe = table.Column<string>(nullable: true),
                    IdPrestamo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pago", x => x.IdPago);
                    table.ForeignKey(
                        name: "FK_Pago_Prestamo_IdPrestamo",
                        column: x => x.IdPrestamo,
                        principalTable: "Prestamo",
                        principalColumn: "IdPrestamo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pago_IdPrestamo",
                table: "Pago",
                column: "IdPrestamo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pago");
        }
    }
}

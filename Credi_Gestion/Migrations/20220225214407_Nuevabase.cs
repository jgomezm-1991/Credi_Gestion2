using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class Nuevabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    IdCliente = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCliente = table.Column<string>(maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(maxLength: 100, nullable: true),
                    Cedula = table.Column<string>(maxLength: 100, nullable: false),
                    Direccion = table.Column<string>(maxLength: 100, nullable: false),
                    Genero = table.Column<string>(maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    Estado = table.Column<string>(maxLength: 100, nullable: true),
                    FechaReg = table.Column<DateTime>(nullable: false),
                    IdUsuario = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    IdPrestamo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(nullable: true),
                    Monto = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    interes = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    Plazo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    Saldo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false),
                    UsuarioRe = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.IdPrestamo);
                    table.ForeignKey(
                        name: "FK_Prestamo_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pagos",
                columns: table => new
                {
                    Id_Pago = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontoPagado = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    FechaPago = table.Column<DateTime>(nullable: false),
                    Saldo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    UsuarioRe = table.Column<string>(nullable: true),
                    IdPrestamo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagos", x => x.Id_Pago);
                    table.ForeignKey(
                        name: "FK_Pagos_Prestamo_IdPrestamo",
                        column: x => x.IdPrestamo,
                        principalTable: "Prestamo",
                        principalColumn: "IdPrestamo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pagos_IdPrestamo",
                table: "Pagos",
                column: "IdPrestamo");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_ClienteId",
                table: "Prestamo",
                column: "ClienteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pagos");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Cliente");
        }
    }
}

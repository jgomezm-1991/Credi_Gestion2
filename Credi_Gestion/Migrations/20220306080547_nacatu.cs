﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Credi_Gestion.Migrations
{
    public partial class nacatu : Migration
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
                    IdCliente = table.Column<int>(nullable: false),
                    Monto = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    Moneda = table.Column<string>(nullable: true),
                    interes = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    MontoTotal = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    Plazo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    Saldo = table.Column<decimal>(type: "Decimal(12, 2)", nullable: false),
                    FechaReg = table.Column<DateTime>(nullable: false),
                    UsuarioRe = table.Column<string>(nullable: true),
                    Estado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo", x => x.IdPrestamo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Prestamo");
        }
    }
}

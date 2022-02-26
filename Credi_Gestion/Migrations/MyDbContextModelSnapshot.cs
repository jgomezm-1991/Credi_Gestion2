﻿// <auto-generated />
using System;
using Credi_Gestion.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Credi_Gestion.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Credi_Gestion.Models.Cliente", b =>
                {
                    b.Property<int>("IdCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<DateTime>("FechaReg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Genero")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCliente");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("Credi_Gestion.Models.Pagos", b =>
                {
                    b.Property<int>("Id_Pago")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaPago")
                        .HasColumnType("datetime2");

                    b.Property<int?>("IdPrestamo")
                        .HasColumnType("int");

                    b.Property<decimal>("MontoPagado")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<string>("UsuarioRe")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_Pago");

                    b.HasIndex("IdPrestamo");

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("Credi_Gestion.Models.Prestamo", b =>
                {
                    b.Property<int>("IdPrestamo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaReg")
                        .HasColumnType("datetime2");

                    b.Property<string>("Moneda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Monto")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<decimal>("MontoTotal")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<decimal>("Plazo")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<decimal>("Saldo")
                        .HasColumnType("Decimal(12, 2)");

                    b.Property<string>("UsuarioRe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("interes")
                        .HasColumnType("Decimal(12, 2)");

                    b.HasKey("IdPrestamo");

                    b.HasIndex("ClienteId");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("Credi_Gestion.Models.Pagos", b =>
                {
                    b.HasOne("Credi_Gestion.Models.Prestamo", "Prestamo")
                        .WithMany()
                        .HasForeignKey("IdPrestamo");
                });

            modelBuilder.Entity("Credi_Gestion.Models.Prestamo", b =>
                {
                    b.HasOne("Credi_Gestion.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");
                });
#pragma warning restore 612, 618
        }
    }
}

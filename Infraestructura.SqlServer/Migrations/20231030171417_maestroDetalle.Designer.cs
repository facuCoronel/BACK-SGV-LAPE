﻿// <auto-generated />
using System;
using Infraestructura.SqlServer.Lape_DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructura.SqlServer.Migrations
{
    [DbContext(typeof(LapeDbContext))]
    [Migration("20231030171417_maestroDetalle")]
    partial class maestroDetalle
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Cantidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("UnidadMedidaId")
                        .HasColumnType("int");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("Cantidades", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoFijo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Detalle", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<Guid>("MaestroId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("MaestroId");

                    b.ToTable("Detalle", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Floracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Floraciones", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Maestro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Entregado")
                        .HasColumnType("bit");

                    b.Property<bool>("Estado")
                        .HasColumnType("bit");

                    b.Property<string>("Fecha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaAPagar")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaEntrega")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("MontoPagado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Pago")
                        .HasColumnType("bit");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Maestro", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CantidadId")
                        .HasColumnType("int");

                    b.Property<decimal>("Costo")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FloracionId")
                        .HasColumnType("int");

                    b.Property<string>("Origen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecioVenta")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<Guid>("ProveedorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("CantidadId");

                    b.HasIndex("FloracionId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("Productos", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Celular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreProveedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefonoFijo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Proveedores", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.UnidadMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Diminutivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UnidadDeMedida")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UnidadesMedida", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.Cantidad", b =>
                {
                    b.HasOne("Domain.Entities.UnidadMedida", "UnidadMedida")
                        .WithMany("Cantidades")
                        .HasForeignKey("UnidadMedidaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("UnidadMedida");
                });

            modelBuilder.Entity("Domain.Entities.Detalle", b =>
                {
                    b.HasOne("Domain.Entities.Maestro", "Maestro")
                        .WithMany("Detalles")
                        .HasForeignKey("MaestroId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Maestro");
                });

            modelBuilder.Entity("Domain.Entities.Maestro", b =>
                {
                    b.HasOne("Domain.Entities.Cliente", "Cliente")
                        .WithMany("Maestros")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Domain.Entities.Producto", b =>
                {
                    b.HasOne("Domain.Entities.Cantidad", "Cantidad")
                        .WithMany("Productos")
                        .HasForeignKey("CantidadId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Floracion", "Floracion")
                        .WithMany("Productos")
                        .HasForeignKey("FloracionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Proveedor", "Proveedor")
                        .WithMany("Productos")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cantidad");

                    b.Navigation("Floracion");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Domain.Entities.Cantidad", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Cliente", b =>
                {
                    b.Navigation("Maestros");
                });

            modelBuilder.Entity("Domain.Entities.Floracion", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.Maestro", b =>
                {
                    b.Navigation("Detalles");
                });

            modelBuilder.Entity("Domain.Entities.Proveedor", b =>
                {
                    b.Navigation("Productos");
                });

            modelBuilder.Entity("Domain.Entities.UnidadMedida", b =>
                {
                    b.Navigation("Cantidades");
                });
#pragma warning restore 612, 618
        }
    }
}

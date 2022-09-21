﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sanguche.Data;

#nullable disable

namespace Sandwich.Database.Migrations
{
    [DbContext(typeof(BDContext))]
    partial class BDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Sanguche.Data.Entidades.PedidoVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CodigoPedido")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("Fecha")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.Property<int>("Horario")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "CodigoPedido")
                        .IsUnique();

                    b.ToTable("tiposdeSanguchasos");
                });

            modelBuilder.Entity("Sanguches.Data.Entidades.Sanguchaso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("MontoXDocena")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.Property<int?>("PedidoVentaId")
                        .HasColumnType("int");

                    b.Property<string>("TipoSanguche")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<int>("codigo")
                        .HasMaxLength(120)
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PedidoVentaId");

                    b.HasIndex(new[] { "Id" }, "codigo")
                        .IsUnique();

                    b.ToTable("sanguchasos");
                });

            modelBuilder.Entity("Sanguches.Data.Entidades.Sanguchaso", b =>
                {
                    b.HasOne("Sanguche.Data.Entidades.PedidoVenta", null)
                        .WithMany("sanguchasos")
                        .HasForeignKey("PedidoVentaId");
                });

            modelBuilder.Entity("Sanguche.Data.Entidades.PedidoVenta", b =>
                {
                    b.Navigation("sanguchasos");
                });
#pragma warning restore 612, 618
        }
    }
}
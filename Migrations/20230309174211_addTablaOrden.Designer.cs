﻿// <auto-generated />
using System;
using MiColmaAPP_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MiColmaAPP_API.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230309174211_addTablaOrden")]
    partial class addTablaOrden
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiColmaAPP_API.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Orden", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("ClienteID");

                    b.ToTable("Ordenes");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(6, 2)
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Orden", b =>
                {
                    b.HasOne("MiColmaAPP_API.Models.Cliente", "Cliente")
                        .WithMany("Ordenes")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Cliente", b =>
                {
                    b.Navigation("Ordenes");
                });
#pragma warning restore 612, 618
        }
    }
}
// <auto-generated />
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
    [Migration("20230309212305_addDatas")]
    partial class addDatas
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Mario"
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Biembo"
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Juana"
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Frank"
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Pote"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteID = 1,
                            Fecha = new DateTime(2023, 3, 10, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5217)
                        },
                        new
                        {
                            Id = 2,
                            ClienteID = 1,
                            Fecha = new DateTime(2023, 3, 10, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5235)
                        },
                        new
                        {
                            Id = 3,
                            ClienteID = 2,
                            Fecha = new DateTime(2023, 3, 13, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5238)
                        },
                        new
                        {
                            Id = 4,
                            ClienteID = 3,
                            Fecha = new DateTime(2023, 3, 14, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5246)
                        },
                        new
                        {
                            Id = 5,
                            ClienteID = 3,
                            Fecha = new DateTime(2023, 3, 15, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5249)
                        });
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.OrdenProducto", b =>
                {
                    b.Property<int>("OrdenID")
                        .HasColumnType("int");

                    b.Property<int>("ProductoID")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("OrdenID", "ProductoID");

                    b.HasIndex("ProductoID");

                    b.ToTable("OrdenProducto");

                    b.HasData(
                        new
                        {
                            OrdenID = 1,
                            ProductoID = 1,
                            Cantidad = 5,
                            Total = 675m
                        },
                        new
                        {
                            OrdenID = 2,
                            ProductoID = 4,
                            Cantidad = 9,
                            Total = 1575m
                        },
                        new
                        {
                            OrdenID = 3,
                            ProductoID = 5,
                            Cantidad = 7,
                            Total = 980m
                        },
                        new
                        {
                            OrdenID = 4,
                            ProductoID = 3,
                            Cantidad = 1,
                            Total = 250m
                        },
                        new
                        {
                            OrdenID = 5,
                            ProductoID = 2,
                            Cantidad = 3,
                            Total = 45m
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nombre = "Cerveza Presidente Peq",
                            Precio = 135m
                        },
                        new
                        {
                            Id = 2,
                            Nombre = "Agua Solecito ",
                            Precio = 15m
                        },
                        new
                        {
                            Id = 3,
                            Nombre = "Jugo Motz",
                            Precio = 250m
                        },
                        new
                        {
                            Id = 4,
                            Nombre = "Cerveza Presidente Normal",
                            Precio = 175m
                        },
                        new
                        {
                            Id = 5,
                            Nombre = "Cerveza Heineken",
                            Precio = 140m
                        });
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

            modelBuilder.Entity("MiColmaAPP_API.Models.OrdenProducto", b =>
                {
                    b.HasOne("MiColmaAPP_API.Models.Orden", "Orden")
                        .WithMany("OrdenProducto")
                        .HasForeignKey("OrdenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MiColmaAPP_API.Models.Producto", "Producto")
                        .WithMany("OrdenProductos")
                        .HasForeignKey("ProductoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Orden");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Cliente", b =>
                {
                    b.Navigation("Ordenes");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Orden", b =>
                {
                    b.Navigation("OrdenProducto");
                });

            modelBuilder.Entity("MiColmaAPP_API.Models.Producto", b =>
                {
                    b.Navigation("OrdenProductos");
                });
#pragma warning restore 612, 618
        }
    }
}

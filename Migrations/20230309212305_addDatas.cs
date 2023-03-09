using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiColmaAPP_API.Migrations
{
    /// <inheritdoc />
    public partial class addDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nombre" },
                values: new object[,]
                {
                    { 1, "Mario" },
                    { 2, "Biembo" },
                    { 3, "Juana" },
                    { 4, "Frank" },
                    { 5, "Pote" }
                });

            migrationBuilder.InsertData(
                table: "Productos",
                columns: new[] { "Id", "Nombre", "Precio" },
                values: new object[,]
                {
                    { 1, "Cerveza Presidente Peq", 135m },
                    { 2, "Agua Solecito ", 15m },
                    { 3, "Jugo Motz", 250m },
                    { 4, "Cerveza Presidente Normal", 175m },
                    { 5, "Cerveza Heineken", 140m }
                });

            migrationBuilder.InsertData(
                table: "Ordenes",
                columns: new[] { "Id", "ClienteID", "Fecha" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 3, 10, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5217) },
                    { 2, 1, new DateTime(2023, 3, 10, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5235) },
                    { 3, 2, new DateTime(2023, 3, 13, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5238) },
                    { 4, 3, new DateTime(2023, 3, 14, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5246) },
                    { 5, 3, new DateTime(2023, 3, 15, 5, 23, 5, 319, DateTimeKind.Local).AddTicks(5249) }
                });

            migrationBuilder.InsertData(
                table: "OrdenProducto",
                columns: new[] { "OrdenID", "ProductoID", "Cantidad", "Total" },
                values: new object[,]
                {
                    { 1, 1, 5, 675m },
                    { 2, 4, 9, 1575m },
                    { 3, 5, 7, 980m },
                    { 4, 3, 1, 250m },
                    { 5, 2, 3, 45m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OrdenProducto",
                keyColumns: new[] { "OrdenID", "ProductoID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrdenProducto",
                keyColumns: new[] { "OrdenID", "ProductoID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "OrdenProducto",
                keyColumns: new[] { "OrdenID", "ProductoID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "OrdenProducto",
                keyColumns: new[] { "OrdenID", "ProductoID" },
                keyValues: new object[] { 4, 3 });

            migrationBuilder.DeleteData(
                table: "OrdenProducto",
                keyColumns: new[] { "OrdenID", "ProductoID" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "Ordenes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ordenes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ordenes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ordenes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ordenes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

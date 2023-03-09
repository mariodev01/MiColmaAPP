using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MiColmaAPP_API.Migrations
{
    /// <inheritdoc />
    public partial class tercermigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Productos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrdenProducto",
                columns: table => new
                {
                    OrdenID = table.Column<int>(type: "int", nullable: false),
                    ProductoID = table.Column<int>(type: "int", nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdenProducto", x => new { x.OrdenID, x.ProductoID });
                    table.ForeignKey(
                        name: "FK_OrdenProducto_Ordenes_OrdenID",
                        column: x => x.OrdenID,
                        principalTable: "Ordenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdenProducto_Productos_ProductoID",
                        column: x => x.ProductoID,
                        principalTable: "Productos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ProductoId",
                table: "Productos",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdenProducto_ProductoID",
                table: "OrdenProducto",
                column: "ProductoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Productos_ProductoId",
                table: "Productos",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Productos_ProductoId",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "OrdenProducto");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ProductoId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Productos");
        }
    }
}

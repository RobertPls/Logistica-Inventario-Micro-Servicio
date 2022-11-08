using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Inventario.EF.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Almacen",
                columns: table => new
                {
                    almacenId = table.Column<Guid>(type: "uuid", nullable: false),
                    descripcion = table.Column<string>(type: "text", nullable: false),
                    capacidadMaxima = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    latitud = table.Column<string>(type: "text", nullable: false),
                    longitud = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacen", x => x.almacenId);
                });

            migrationBuilder.CreateTable(
                name: "Producto",
                columns: table => new
                {
                    productoId = table.Column<Guid>(type: "uuid", nullable: false),
                    nombreProducto = table.Column<string>(type: "text", nullable: false),
                    precio = table.Column<decimal>(type: "numeric(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto", x => x.productoId);
                });

            migrationBuilder.CreateTable(
                name: "StockAlmacen",
                columns: table => new
                {
                    stockAlmacenId = table.Column<Guid>(type: "uuid", nullable: false),
                    cantidad = table.Column<int>(type: "integer", nullable: false, defaultValue: 0),
                    productoId = table.Column<Guid>(type: "uuid", nullable: false),
                    almacenId = table.Column<Guid>(type: "uuid", nullable: false),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockAlmacen", x => x.stockAlmacenId);
                    table.ForeignKey(
                        name: "FK_StockAlmacen_Almacen_almacenId",
                        column: x => x.almacenId,
                        principalTable: "Almacen",
                        principalColumn: "almacenId",
                        onDelete: ReferentialAction.Cascade);

                    table.ForeignKey(
                        name: "FK_StockAlmacen_Producto_productoId",
                        column: x => x.productoId,
                        principalTable: "Producto",
                        principalColumn: "productoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StockAlmacen_almacenId",
                table: "StockAlmacen",
                column: "almacenId");

            migrationBuilder.CreateIndex(
                name: "IX_StockAlmacen_productoId",
                table: "StockAlmacen",
                column: "productoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StockAlmacen");

            migrationBuilder.DropTable(
                name: "Almacen");

            migrationBuilder.DropTable(
                name: "Producto");
        }
    }
}

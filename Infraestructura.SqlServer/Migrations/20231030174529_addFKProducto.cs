using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class addFKProducto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Detalle_ProductoId",
                table: "Detalle",
                column: "ProductoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Detalle_Productos_ProductoId",
                table: "Detalle",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Detalle_Productos_ProductoId",
                table: "Detalle");

            migrationBuilder.DropIndex(
                name: "IX_Detalle_ProductoId",
                table: "Detalle");
        }
    }
}

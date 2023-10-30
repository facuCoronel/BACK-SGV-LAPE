using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.SqlServer.Migrations
{
    /// <inheritdoc />
    public partial class addcolumndminutivo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Diminutivo",
                table: "UnidadesMedida",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Diminutivo",
                table: "UnidadesMedida");
        }
    }
}

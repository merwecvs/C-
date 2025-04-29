using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SotaApp.Migrations
{
    /// <inheritdoc />
    public partial class IlkKurulum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UrunStok",
                table: "Urunler",
                newName: "Stok");

            migrationBuilder.AddColumn<decimal>(
                name: "Fiyat",
                table: "Urunler",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "Urunler");

            migrationBuilder.RenameColumn(
                name: "Stok",
                table: "Urunler",
                newName: "UrunStok");
        }
    }
}

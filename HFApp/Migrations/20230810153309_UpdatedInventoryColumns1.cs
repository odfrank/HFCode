using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HFApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedInventoryColumns1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InventoryId",
                table: "Inventories",
                newName: "InventorySKU");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InventorySKU",
                table: "Inventories",
                newName: "InventoryId");
        }
    }
}

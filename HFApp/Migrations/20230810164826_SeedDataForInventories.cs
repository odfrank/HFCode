using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataForInventories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ProductInventories",
                columns: new[] { "InventoryId", "BinLookupId", "FacilityId", "InventorySKU", "ProductId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, "SP7875", 1, 20 },
                    { 2, 2, 2, "TR87680", 2, 45 },
                    { 3, 2, 1, "MK676554", 1, 15 },
                    { 4, 3, 2, "YE98767", 2, 30 },
                    { 5, 4, 1, "XR23423", 1, 10 },
                    { 6, 1, 2, "PW98762", 2, 25 },
                    { 7, 3, 1, "BM87684", 1, 20 },
                    { 8, 2, 2, "BH67655", 2, 15 },
                    { 9, 1, 1, "WT98768", 1, 50 },
                    { 10, 4, 2, "TS3456", 2, 15 },
                    { 11, 1, 1, "WDG123", 1, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductInventories",
                keyColumn: "InventoryId",
                keyValue: 11);
        }
    }
}

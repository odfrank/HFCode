using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFApp.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForBinLookupAndProductTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Inventories",
                newName: "BinLookupId");

            migrationBuilder.AlterColumn<int>(
                name: "BinLookupId",
                table: "Inventories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryId");

            migrationBuilder.CreateTable(
                name: "BinLookup",
                columns: table => new
                {
                    BinLookupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BinNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Height = table.Column<int>(type: "int", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BinLookup", x => x.BinLookupId);
                });

            migrationBuilder.InsertData(
                table: "BinLookup",
                columns: new[] { "BinLookupId", "BinNumber", "Description", "Height", "Length", "Location", "Width" },
                values: new object[,]
                {
                    { 1, "T345", "Large bin", 10, 10, "Row 2, Slot 1", 50 },
                    { 2, "T5789", "Small bin", 5, 5, "Row 1, Slot 1", 25 },
                    { 3, "T9876", "Large bin", 10, 10, "Row 3, Slot 2", 50 },
                    { 4, "T098", "Medium bin", 7, 10, "Row 3, Slot 1", 30 },
                    { 5, "T349", "Small bin", 5, 5, "Row 1, Slot 2", 25 },
                    { 6, "T5789", "Large bin", 10, 10, "Row 4, Slot 5", 50 },
                    { 7, "T9875", "Large bin", 10, 10, "Row 2, Slot 2", 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Price", "ProductDescription", "ProductName" },
                values: new object[,]
                {
                    { 1, 30m, "Item 1", "Item 1" },
                    { 2, 40m, "Item 2", "Item 2" },
                    { 3, 5m, "Item 3", "Item 3" },
                    { 4, 15m, "Item 4", "Item 4" },
                    { 5, 26m, "Item 5", "Item 5" },
                    { 6, 50m, "Item 6", "Item 6" },
                    { 7, 10m, "Item 7", "Item 7" },
                    { 8, 3m, "Item 8", "Item 8" },
                    { 9, 14m, "Item 9", "Item 9" },
                    { 10, 60m, "Item 10", "Item 10" },
                    { 11, 8m, "Item 11", "Item 11" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BinLookup");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "BinLookupId",
                table: "Inventories",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Inventories",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HFApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedFacilityTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Facilities",
                columns: new[] { "FacilityId", "FacilityName", "Location" },
                values: new object[,]
                {
                    { 1, "AbujaStore", "Abuja, Nigeria" },
                    { 2, "LagosStore", "Lagos, Nigeria" },
                    { 3, "TexasStore", "Texas, USA" },
                    { 4, "AccraStore", "Accra, Ghana" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Facilities",
                keyColumn: "FacilityId",
                keyValue: 4);
        }
    }
}

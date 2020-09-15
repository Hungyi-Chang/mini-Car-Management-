using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class SeedValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Doors", "Engine", "Make", "Model", "VehicleType", "bodyType", "wheel" },
                values: new object[] { 1, "4", "test", "1998", "Mercedes", "Car", "hatchback", "5" });

            migrationBuilder.InsertData(
                table: "Values",
                columns: new[] { "Id", "Doors", "Engine", "Make", "Model", "VehicleType", "bodyType", "wheel" },
                values: new object[] { 2, "4", "test", "1998", "Mercedes", "Car", "hatchback", "5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Values",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

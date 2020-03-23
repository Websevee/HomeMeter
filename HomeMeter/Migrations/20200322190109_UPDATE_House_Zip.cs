using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMeter.Migrations
{
    public partial class UPDATE_House_Zip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "House",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House",
                columns: new[] { "Zip", "Country", "City", "Street", "Number" },
                unique: true,
                filter: "[Zip] IS NOT NULL AND [Country] IS NOT NULL AND [City] IS NOT NULL AND [Street] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House");

            migrationBuilder.AlterColumn<int>(
                name: "Zip",
                table: "House",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House",
                columns: new[] { "Zip", "Country", "City", "Street", "Number" },
                unique: true,
                filter: "[Country] IS NOT NULL AND [City] IS NOT NULL AND [Street] IS NOT NULL");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMeter.Migrations
{
    public partial class New2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House");

            migrationBuilder.AlterColumn<int>(
                name: "Zip",
                table: "House",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House",
                columns: new[] { "Zip", "Country", "City", "Street", "Number" },
                unique: true,
                filter: "[Country] IS NOT NULL AND [City] IS NOT NULL AND [Street] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House");

            migrationBuilder.AlterColumn<string>(
                name: "Zip",
                table: "House",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_House_Zip_Country_City_Street_Number",
                table: "House",
                columns: new[] { "Zip", "Country", "City", "Street", "Number" },
                unique: true,
                filter: "[Zip] IS NOT NULL AND [Country] IS NOT NULL AND [City] IS NOT NULL AND [Street] IS NOT NULL");
        }
    }
}

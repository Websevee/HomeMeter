using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMeter.Migrations
{
    public partial class UPDATE_Meter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Meter");

            migrationBuilder.AddColumn<int>(
                name: "SerialNumber",
                table: "Meter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter",
                column: "SerialNumber");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter");

            migrationBuilder.DropColumn(
                name: "SerialNumber",
                table: "Meter");

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Meter",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

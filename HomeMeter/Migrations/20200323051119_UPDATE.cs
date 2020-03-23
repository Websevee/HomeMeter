using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMeter.Migrations
{
    public partial class UPDATE : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter");

            migrationBuilder.CreateIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter",
                column: "SerialNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter");

            migrationBuilder.CreateIndex(
                name: "IX_Meter_SerialNumber",
                table: "Meter",
                column: "SerialNumber");
        }
    }
}

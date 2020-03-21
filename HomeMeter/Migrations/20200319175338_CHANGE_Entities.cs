using Microsoft.EntityFrameworkCore.Migrations;

namespace HomeMeter.Migrations
{
    public partial class CHANGE_Entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meter_House_HouseId",
                table: "Meter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meter",
                table: "Meter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_House",
                table: "House");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Meter");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "House");

            migrationBuilder.AddColumn<int>(
                name: "MeterId",
                table: "Meter",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "HouseId",
                table: "House",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meter",
                table: "Meter",
                column: "MeterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_House",
                table: "House",
                column: "HouseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meter_House_HouseId",
                table: "Meter",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "HouseId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meter_House_HouseId",
                table: "Meter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Meter",
                table: "Meter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_House",
                table: "House");

            migrationBuilder.DropColumn(
                name: "MeterId",
                table: "Meter");

            migrationBuilder.DropColumn(
                name: "HouseId",
                table: "House");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Meter",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "House",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Meter",
                table: "Meter",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_House",
                table: "House",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Meter_House_HouseId",
                table: "Meter",
                column: "HouseId",
                principalTable: "House",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

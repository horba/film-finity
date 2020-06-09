using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class FixSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -9,
                column: "ImageSource",
                value: "StaticFiles/images/9.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -9,
                column: "ImageSource",
                value: "StaticFiles/images/9.jpg");
        }
    }
}

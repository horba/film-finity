using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    FilmId = table.Column<int>(nullable: false),
                    ContentType = table.Column<int>(nullable: false),
                    ReviewTitle = table.Column<string>(maxLength: 150, nullable: false),
                    ReviewContent = table.Column<string>(maxLength: 2000, nullable: false),
                    PublishTime = table.Column<DateTime>(nullable: false),
                    DirectingRating = table.Column<float>(nullable: false),
                    PlotRating = table.Column<float>(nullable: false),
                    SpectacleRating = table.Column<float>(nullable: false),
                    ActorsRating = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 177, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 6, 29, 15, 5, 35, 505, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 6, 29, 15, 5, 35, 511, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 6, 29, 15, 5, 35, 511, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 6, 29, 15, 5, 35, 511, DateTimeKind.Local).AddTicks(5506));
        }
    }
}

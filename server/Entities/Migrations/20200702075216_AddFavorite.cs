using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddFavorite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Favorites",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContentType = table.Column<int>(nullable: false),
                    ContentId = table.Column<int>(nullable: false),
                    AddedTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favorites", x => x.Id);
                });
            migrationBuilder.InsertData(
                table: "Favorites",
                columns: new[] { "ContentType", "ContentId", "AddedTime" },
                values: new object[,]
                {
                                { 1, 1, "2020-06-11 18:12:31.9377768" },
                                { 0, 2, "2020-06-20 14:22:23.9377768" },
                                { 1, 3, "2020-06-21 09:32:34.9377768" },

                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favorites");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class ChangeAndAddCelebritiesModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Celebrities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "FamilyStatus",
                table: "Celebrities",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Celebrities",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PlaceOfBirthday",
                table: "Celebrities",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StarSing",
                table: "Celebrities",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "CelebrityBiography",
                columns: table => new
                {
                    CelebrityId = table.Column<int>(nullable: false),
                    ChildhoodAndYouth = table.Column<string>(nullable: true),
                    ChildhoodAndYouthImage = table.Column<string>(nullable: true),
                    PersonalLife = table.Column<string>(nullable: true),
                    PersonalLifeImage = table.Column<string>(nullable: true),
                    CareerInCinema = table.Column<string>(nullable: true),
                    CareerInCinemaImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelebrityBiography", x => x.CelebrityId);
                    table.ForeignKey(
                        name: "FK_CelebrityBiography_Celebrities_CelebrityId",
                        column: x => x.CelebrityId,
                        principalTable: "Celebrities",
                        principalColumn: "CelebrityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CelebrityNetworkingSites",
                columns: table => new
                {
                    CelebrityId = table.Column<int>(nullable: false),
                    Instagram = table.Column<string>(nullable: true),
                    Facebook = table.Column<string>(nullable: true),
                    Twitter = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelebrityNetworkingSites", x => x.CelebrityId);
                    table.ForeignKey(
                        name: "FK_CelebrityNetworkingSites_Celebrities_CelebrityId",
                        column: x => x.CelebrityId,
                        principalTable: "Celebrities",
                        principalColumn: "CelebrityId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CelebrityBiography");

            migrationBuilder.DropTable(
                name: "CelebrityNetworkingSites");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Celebrities");

            migrationBuilder.DropColumn(
                name: "FamilyStatus",
                table: "Celebrities");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Celebrities");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirthday",
                table: "Celebrities");

            migrationBuilder.DropColumn(
                name: "StarSing",
                table: "Celebrities");
        }
    }
}

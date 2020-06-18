using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class CreateAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Serials",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Rating = table.Column<double>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Serials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerialCelebrities",
                columns: table => new
                {
                    SerialId = table.Column<int>(nullable: false),
                    CelebrityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialCelebrities", x => new { x.SerialId, x.CelebrityId });
                    table.ForeignKey(
                        name: "FK_SerialCelebrities_Celebrities_CelebrityId",
                        column: x => x.CelebrityId,
                        principalTable: "Celebrities",
                        principalColumn: "CelebrityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerialCelebrities_Serials_SerialId",
                        column: x => x.SerialId,
                        principalTable: "Serials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SerialGenreTitles",
                columns: table => new
                {
                    SerialId = table.Column<int>(nullable: false),
                    GenreId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialGenreTitles", x => new { x.SerialId, x.GenreId });
                    table.ForeignKey(
                        name: "FK_SerialGenreTitles_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SerialGenreTitles_Serials_SerialId",
                        column: x => x.SerialId,
                        principalTable: "Serials",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "фантастика" },
                    { 2, "драма" },
                    { 3, "триллер" },
                    { 4, "боевик" },
                    { 5, "приключения" },
                    { 6, "детектив" },
                    { 7, "комедия" },
                    { 8, "ужасы" }
                });

            migrationBuilder.InsertData(
                table: "Serials",
                columns: new[] { "Id", "ImageSource", "Name", "Rating", "Year" },
                values: new object[,]
                {
                    { 9, "StaticFiles/images/19.jpg", "Hi-Fi / Фанатик (1 сезон)", 5.0, 2020 },
                    { 8, "StaticFiles/images/18.jpg", "Замок и ключ (1 сезон)", 5.0, 2020 },
                    { 7, "StaticFiles/images/17.jpg", "Звёздный путь: Пикар (1 сезон)", 5.0, 2020 },
                    { 6, "StaticFiles/images/16.jpg", "Пятая авеню (1 сезон)", 5.0, 2020 },
                    { 2, "StaticFiles/images/12.jpg", "Викинги (1-6 сезон)", 4.0, 2013 },
                    { 4, "StaticFiles/images/14.jpg", "Чужак (1 сезон)", 5.0, 2020 },
                    { 3, "StaticFiles/images/13.jpg", "Ведьмак (1 сезон)", 5.0, 2019 },
                    { 10, "StaticFiles/images/20.jpg", "Разрабы (1 сезон)", 5.0, 2020 },
                    { 1, "StaticFiles/images/11.jpg", "Видоизменённый углерод (1-2 сезон)", 3.0, 2018 },
                    { 5, "StaticFiles/images/15.jpg", "Маленькая Америка (1 сезон)", 5.0, 2020 },
                    { 11, "StaticFiles/images/21.jpg", "Охотники (1 сезон)", 5.0, 2020 }
                });

            migrationBuilder.InsertData(
                table: "SerialCelebrities",
                columns: new[] { "SerialId", "CelebrityId" },
                values: new object[,]
                {
                    { 7, -8 },
                    { 8, -9 },
                    { 7, -9 },
                    { 7, -7 },
                    { 9, -7 },
                    { 9, -8 },
                    { 6, -9 },
                    { 6, -8 },
                    { 6, -7 },
                    { 9, -9 },
                    { 5, -6 },
                    { 8, -8 },
                    { 5, -4 },
                    { 5, -5 },
                    { 8, -7 },
                    { 10, -8 },
                    { 4, -3 },
                    { 4, -2 },
                    { 4, -1 },
                    { 10, -9 },
                    { 11, -9 },
                    { 10, -7 },
                    { 11, -7 },
                    { 11, -8 }
                });

            migrationBuilder.InsertData(
                table: "SerialGenreTitles",
                columns: new[] { "SerialId", "GenreId" },
                values: new object[,]
                {
                    { 11, 2 },
                    { 8, 2 },
                    { 8, 4 },
                    { 10, 4 },
                    { 10, 5 },
                    { 10, 2 },
                    { 9, 2 },
                    { 9, 4 },
                    { 8, 5 },
                    { 9, 5 },
                    { 1, 1 },
                    { 7, 4 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 2 },
                    { 2, 4 },
                    { 2, 5 },
                    { 3, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 2 },
                    { 4, 4 },
                    { 4, 5 },
                    { 5, 2 },
                    { 5, 4 },
                    { 5, 5 },
                    { 6, 2 },
                    { 6, 4 },
                    { 6, 5 },
                    { 11, 4 },
                    { 7, 2 },
                    { 7, 5 },
                    { 11, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SerialCelebrities_CelebrityId",
                table: "SerialCelebrities",
                column: "CelebrityId");

            migrationBuilder.CreateIndex(
                name: "IX_SerialGenreTitles_GenreId",
                table: "SerialGenreTitles",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialCelebrities");

            migrationBuilder.DropTable(
                name: "SerialGenreTitles");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Serials");
        }
    }
}

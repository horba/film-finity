using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddMoviePage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    ActorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.ActorId);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieTitle = table.Column<string>(nullable: true),
                    CountStars = table.Column<int>(nullable: false),
                    ReleaseYear = table.Column<int>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "ActorsLists",
                columns: table => new
                {
                    MovieId = table.Column<int>(nullable: false),
                    ActorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActorsLists", x => new { x.MovieId, x.ActorId });
                    table.ForeignKey(
                        name: "FK_ActorsLists_Actors_ActorId",
                        column: x => x.ActorId,
                        principalTable: "Actors",
                        principalColumn: "ActorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsLists_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName" },
                values: new object[,]
                {
                    { 1, "Том Харпер" },
                    { 21, "Тика Самптер" },
                    { 23, "Мэти Янь" },
                    { 24, "Марго Робби" },
                    { 25, "Джерни Смоллет-Белл" },
                    { 26, "Мэри Элизабет" },
                    { 27, "Грета Гервич" },
                    { 28, "Сирта Ронан" },
                    { 29, "Тимоти Шаламе" },
                    { 30, "Флоренс Пью" },
                    { 31, "Эмма Уотсон" },
                    { 32, "Сирзат Яхуп" },
                    { 33, "Ху Цзюнь" },
                    { 34, "Юань Цуань" },
                    { 35, "Берик Айтжанов" },
                    { 36, "Аружан Джазильбек" },
                    { 20, "Джеймс Марсден" },
                    { 19, "Джим Керри" },
                    { 22, "Бен Шварц" },
                    { 17, "Кевин Харт" },
                    { 2, "Филисити Джонс" },
                    { 3, "Эдди Редмейн" },
                    { 4, "Химет Патель" },
                    { 5, "Режиссер" },
                    { 18, "Джефф Фаулер" },
                    { 7, "Дин-Чарльз Чакман" },
                    { 8, "Ричард Мэдден" },
                    { 9, "Джордж Нолфи" },
                    { 6, "Джордж Маккей" },
                    { 11, "Сэмюел Лерой Джексон" },
                    { 12, "Ниа Лонг" },
                    { 13, "Джейк Кэздан" },
                    { 14, "Дуэйн Джонсон" },
                    { 15, "Карен Гиллан" },
                    { 16, "Джейк Блэк" },
                    { 10, "Энтони Маки" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "CountStars", "ImageSource", "MovieTitle", "ReleaseYear" },
                values: new object[,]
                {
                    { 7, 5, "StaticFiles/images/17.jpg", "Маленькие женщины", 2019 },
                    { 1, 5, "StaticFiles/images/11.jpg", "Аэронавты", 2019 },
                    { 2, 5, "StaticFiles/images/12.jpg", "1917", 2019 },
                    { 3, 5, "StaticFiles/images/13.jpg", "Джуманджи: Новый уровень", 2019 },
                    { 4, 5, "StaticFiles/images/14.jpg", "Банкир", 2020 },
                    { 5, 5, "StaticFiles/images/15.jpg", "Соник в кино", 2020 },
                    { 6, 5, "StaticFiles/images/16.jpg", "Хищные птицы: Потрясающая история Харли Квинн", 2020 },
                    { 8, 5, "StaticFiles/images/18.jpg", "Композитор", 2019 }
                });

            migrationBuilder.InsertData(
                table: "ActorsLists",
                columns: new[] { "MovieId", "ActorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 21 },
                    { 5, 22 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 6, 26 },
                    { 5, 20 },
                    { 7, 27 },
                    { 7, 29 },
                    { 7, 30 },
                    { 7, 31 },
                    { 8, 32 },
                    { 8, 33 },
                    { 8, 34 },
                    { 7, 28 },
                    { 5, 19 },
                    { 5, 18 },
                    { 4, 17 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 8, 35 },
                    { 8, 36 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActorsLists_ActorId",
                table: "ActorsLists",
                column: "ActorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActorsLists");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddMoviesPage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Actors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Rate = table.Column<int>(nullable: false),
                    ReleaseYear = table.Column<int>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
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
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActorsLists_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Том Харпер" },
                    { 25, "Джерни Смоллет-Белл" },
                    { 26, "Мэри Элизабет Уинстэд" },
                    { 27, "Грета Гервич" },
                    { 29, "Тимоти Шаламе" },
                    { 30, "Флоренс Пью" },
                    { 31, "Эмма Уотсон" },
                    { 32, "Сирзат Яхуп" },
                    { 33, "Ху Цзюнь" },
                    { 24, "Марго Робби" },
                    { 34, "Юань Цуань" },
                    { 36, "Аружан Джазильбекова" },
                    { 37, "Фиби Фокс" },
                    { 38, "Левин Ллойд" },
                    { 39, "Бенедикт Камбербэтч" },
                    { 40, "Ник Джонас" },
                    { 41, "Николас Холт" },
                    { 42, "Наташа Ротуэлл" },
                    { 43, "Элайза Сканлен" },
                    { 35, "Берик Айтжанов" },
                    { 23, "Мэти Янь" },
                    { 28, "Сирта Ронан" },
                    { 21, "Тика Самптер" },
                    { 2, "Филисити Джонс" },
                    { 3, "Эдди Редмейн" },
                    { 4, "Химет Патель" },
                    { 5, "Режиссер" },
                    { 22, "Бен Шварц" },
                    { 7, "Дин-Чарльз Чакман" },
                    { 8, "Ричард Мэдден" },
                    { 9, "Джордж Нолфи" },
                    { 10, "Энтони Маки" },
                    { 11, "Сэмюел Лерой Джексон" },
                    { 6, "Джордж Маккей" },
                    { 13, "Джейк Кэздан" },
                    { 14, "Дуэйн Джонсон" },
                    { 15, "Карен Гиллан" },
                    { 16, "Джейк Блэк" },
                    { 17, "Кевин Харт" },
                    { 18, "Джефф Фаулер" },
                    { 19, "Джим Керри" },
                    { 20, "Джеймс Марсден" },
                    { 12, "Ниа Лонг" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "ImageSource", "Rate", "ReleaseYear", "Title" },
                values: new object[,]
                {
                    { 8, "StaticFiles/images/Composer.jpg", 5, 2019, "Композитор" },
                    { 7, "StaticFiles/images/LittleWomen.jpg", 5, 2019, "Маленькие женщины" },
                    { 6, "StaticFiles/images/PreyBirdsHQ.jpg", 5, 2020, "Хищные птицы: Потрясающая история Харли Квинн" },
                    { 5, "StaticFiles/images/SonikH.jpg", 5, 2020, "Соник в кино" },
                    { 2, "StaticFiles/images/1917.jpg", 5, 2019, "1917" },
                    { 3, "StaticFiles/images/JumanjiNL.jpg", 5, 2019, "Джуманджи: Новый уровень" },
                    { 1, "StaticFiles/images/Aeronauts.jpg", 5, 2019, "Аэронавты" },
                    { 4, "StaticFiles/images/Banker.jpg", 5, 2020, "Банкир" }
                });

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

            migrationBuilder.InsertData(
                table: "ActorsLists",
                columns: new[] { "MovieId", "ActorId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 5, 19 },
                    { 5, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 5, 42 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 5, 18 },
                    { 6, 26 },
                    { 7, 28 },
                    { 7, 29 },
                    { 7, 30 },
                    { 7, 31 },
                    { 7, 43 },
                    { 8, 32 },
                    { 8, 33 },
                    { 8, 34 },
                    { 7, 27 },
                    { 8, 35 },
                    { 4, 41 },
                    { 4, 16 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 37 },
                    { 1, 38 },
                    { 2, 5 },
                    { 2, 6 },
                    { 2, 7 },
                    { 4, 17 },
                    { 2, 8 },
                    { 3, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 40 },
                    { 4, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 2, 39 },
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

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 6, 27, 19, 48, 15, 285, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 6, 27, 19, 48, 15, 287, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 6, 27, 19, 48, 15, 287, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 6, 27, 19, 48, 15, 287, DateTimeKind.Local).AddTicks(2744));
        }
    }
}

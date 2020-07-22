using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitAndSeedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CelebrityJobTitles_Celebrity_CelebrityId",
                table: "CelebrityJobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_SerialCelebrities_Celebrity_CelebrityId",
                table: "SerialCelebrities");

            migrationBuilder.DropTable(
                name: "Celebrity");

            migrationBuilder.DropColumn(
                name: "FullName",
                table: "Celebrities");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Celebrities");

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
                value: new DateTime(2020, 7, 8, 19, 57, 57, 967, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 7, 8, 19, 57, 57, 970, DateTimeKind.Local).AddTicks(994));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 7, 8, 19, 57, 57, 970, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 7, 8, 19, 57, 57, 970, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsLists_Actors_ActorId",
                table: "ActorsLists",
                column: "ActorId",
                principalTable: "Actors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ActorsLists_Movies_MovieId",
                table: "ActorsLists",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CelebrityJobTitles_Celebrities_CelebrityId",
                table: "CelebrityJobTitles",
                column: "CelebrityId",
                principalTable: "Celebrities",
                principalColumn: "CelebrityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerialCelebrities_Celebrities_CelebrityId",
                table: "SerialCelebrities",
                column: "CelebrityId",
                principalTable: "Celebrities",
                principalColumn: "CelebrityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ActorsLists_Actors_ActorId",
                table: "ActorsLists");

            migrationBuilder.DropForeignKey(
                name: "FK_ActorsLists_Movies_MovieId",
                table: "ActorsLists");

            migrationBuilder.DropForeignKey(
                name: "FK_CelebrityJobTitles_Celebrities_CelebrityId",
                table: "CelebrityJobTitles");

            migrationBuilder.DropForeignKey(
                name: "FK_SerialCelebrities_Celebrities_CelebrityId",
                table: "SerialCelebrities");

            migrationBuilder.DropTable(
                name: "Actors");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.AddColumn<string>(
                name: "FullName",
                table: "Celebrities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Celebrities",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "Celebrity",
                columns: table => new
                {
                    TempId = table.Column<int>(nullable: false),
                    TempId1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.UniqueConstraint("AK_Celebrity_TempId", x => x.TempId);
                    table.UniqueConstraint("AK_Celebrity_TempId1", x => x.TempId1);
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

            migrationBuilder.AddForeignKey(
                name: "FK_CelebrityJobTitles_Celebrity_CelebrityId",
                table: "CelebrityJobTitles",
                column: "CelebrityId",
                principalTable: "Celebrity",
                principalColumn: "TempId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SerialCelebrities_Celebrity_CelebrityId",
                table: "SerialCelebrities",
                column: "CelebrityId",
                principalTable: "Celebrity",
                principalColumn: "TempId1",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

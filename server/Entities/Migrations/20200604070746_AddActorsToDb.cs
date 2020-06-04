using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddActorsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 26,
                column: "ActorName",
                value: "Мэри Элизабет Уинстэд");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 36,
                column: "ActorName",
                value: "Аружан Джазильбекова");

            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "ActorId", "ActorName" },
                values: new object[,]
                {
                    { 37, "Фиби Фокс" },
                    { 38, "Левин Ллойд" },
                    { 39, "Бенедикт Камбербэтч" },
                    { 40, "Ник Джонас" },
                    { 41, "Николас Холт" },
                    { 42, "Наташа Ротуэлл" },
                    { 43, "Элайза Сканлен" }
                });

            migrationBuilder.InsertData(
                table: "ActorsLists",
                columns: new[] { "MovieId", "ActorId" },
                values: new object[,]
                {
                    { 1, 37 },
                    { 1, 38 },
                    { 2, 39 },
                    { 3, 40 },
                    { 4, 41 },
                    { 5, 42 },
                    { 7, 43 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 1, 37 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 1, 38 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 2, 39 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 3, 40 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 4, 41 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 5, 42 });

            migrationBuilder.DeleteData(
                table: "ActorsLists",
                keyColumns: new[] { "MovieId", "ActorId" },
                keyValues: new object[] { 7, 43 });

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 26,
                column: "ActorName",
                value: "Мэри Элизабет");

            migrationBuilder.UpdateData(
                table: "Actors",
                keyColumn: "ActorId",
                keyValue: 36,
                column: "ActorName",
                value: "Аружан Джазильбек");
        }
    }
}

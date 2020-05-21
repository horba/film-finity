using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class sec : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -3, 6 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -1, 3 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -1, 6 });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -4,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 121000, "Уилл", "Смит" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -3,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 126000, "Роберт", "Дауни (младший)" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -2,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 127000, "Райан", "Рейнольдс" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -1,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 134000, "Хью", "Джекман" });

            migrationBuilder.InsertData(
                table: "Celebrities",
                columns: new[] { "CelebrityId", "CelebrityPicURL", "CountViews", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -9, "", 50000, "Ханс", "Циммер" },
                    { -8, "", 20000, "Роджер", "Дикинс" },
                    { -7, "", 91000, "Натали", "Портман" },
                    { -10, "", 95000, "Квентин", "Тарантино" },
                    { -5, "", 120500, "Брэд", "Питт" },
                    { -6, "", 120000, "Леонардо", "Ди Каприо" }
                });

            migrationBuilder.InsertData(
                table: "CelebrityJobTitles",
                columns: new[] { "CelebrityId", "JobTitleId" },
                values: new object[,]
                {
                    { -4, 4 },
                    { -4, 2 },
                    { -4, 1 },
                    { -3, 4 },
                    { -2, 4 }
                });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "Job",
                value: "актер");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "Job",
                value: "режиссер");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "Job",
                value: "сценарист");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 4,
                column: "Job",
                value: "продюсер");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 5,
                column: "Job",
                value: "оператор");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 6,
                column: "Job",
                value: "композитор");

            migrationBuilder.InsertData(
                table: "CelebrityJobTitles",
                columns: new[] { "CelebrityId", "JobTitleId" },
                values: new object[,]
                {
                    { -5, 1 },
                    { -5, 4 },
                    { -6, 1 },
                    { -6, 4 },
                    { -7, 1 },
                    { -7, 2 },
                    { -7, 3 },
                    { -7, 4 },
                    { -8, 5 },
                    { -9, 6 },
                    { -10, 1 },
                    { -10, 2 },
                    { -10, 3 },
                    { -10, 4 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -10, 1 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -10, 2 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -10, 3 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -10, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -9, 6 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -8, 5 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -7, 1 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -7, 2 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -7, 3 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -7, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -6, 1 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -6, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -5, 1 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -5, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -4, 1 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -4, 2 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -4, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -3, 4 });

            migrationBuilder.DeleteData(
                table: "CelebrityJobTitles",
                keyColumns: new[] { "CelebrityId", "JobTitleId" },
                keyValues: new object[] { -2, 4 });

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -5);

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -4,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 126000, "Роберт", "Дауни (младший)" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -3,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 127000, "Райан", "Рейнольдс" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -2,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 134000, "Хью", "Джекман" });

            migrationBuilder.UpdateData(
                table: "Celebrities",
                keyColumn: "CelebrityId",
                keyValue: -1,
                columns: new[] { "CountViews", "FirstName", "LastName" },
                values: new object[] { 121000, "Уилл", "Смит" });

            migrationBuilder.InsertData(
                table: "CelebrityJobTitles",
                columns: new[] { "CelebrityId", "JobTitleId" },
                values: new object[,]
                {
                    { -1, 3 },
                    { -1, 6 },
                    { -3, 6 }
                });

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 1,
                column: "Job",
                value: "Actor");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 2,
                column: "Job",
                value: "Writer");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 3,
                column: "Job",
                value: "Director");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 4,
                column: "Job",
                value: "Composer");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 5,
                column: "Job",
                value: "Cinematographer");

            migrationBuilder.UpdateData(
                table: "JobTitles",
                keyColumn: "JobTitleId",
                keyValue: 6,
                column: "Job",
                value: "Producer");
        }
    }
}

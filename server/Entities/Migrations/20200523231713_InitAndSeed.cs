using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitAndSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Celebrities",
                columns: table => new
                {
                    CelebrityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CountViews = table.Column<int>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celebrities", x => x.CelebrityId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "CelebrityJobTitles",
                columns: table => new
                {
                    CelebrityId = table.Column<int>(nullable: false),
                    JobTitleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CelebrityJobTitles", x => new { x.CelebrityId, x.JobTitleId });
                    table.ForeignKey(
                        name: "FK_CelebrityJobTitles_Celebrities_CelebrityId",
                        column: x => x.CelebrityId,
                        principalTable: "Celebrities",
                        principalColumn: "CelebrityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CelebrityJobTitles_JobTitles_JobTitleId",
                        column: x => x.JobTitleId,
                        principalTable: "JobTitles",
                        principalColumn: "JobTitleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Celebrities",
                columns: new[] { "CelebrityId", "CountViews", "FirstName", "ImageSource", "LastName" },
                values: new object[,]
                {
                    { -1, 134000, "Хью", "StaticFiles/images/1.jpg", "Джекман" },
                    { -2, 127000, "Райан", "StaticFiles/images/2.jpg", "Рейнольдс" },
                    { -3, 126000, "Роберт", "StaticFiles/images/3.jpg", "Дауни (младший)" },
                    { -4, 121000, "Уилл", "StaticFiles/images/4.jpg", "Смит" },
                    { -5, 120500, "Брэд", "StaticFiles/images/5.jpg", "Питт" },
                    { -6, 120000, "Леонардо", "StaticFiles/images/6.jpg", "Ди Каприо" },
                    { -7, 91000, "Натали", "StaticFiles/images/7.jpg", "Портман" },
                    { -8, 20000, "Роджер", "StaticFiles/images/8.jpg", "Дикинс" },
                    { -9, 50000, "Ханс", "StaticFiles/images/9.jpg", "Циммер" },
                    { -10, 95000, "Квентин", "StaticFiles/images/10.jpg", "Тарантино" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "JobTitleId", "JobName" },
                values: new object[,]
                {
                    { 1, "актер" },
                    { 2, "режиссер" },
                    { 3, "сценарист" },
                    { 4, "продюсер" },
                    { 5, "оператор" },
                    { 6, "композитор" }
                });

            migrationBuilder.InsertData(
                table: "CelebrityJobTitles",
                columns: new[] { "CelebrityId", "JobTitleId" },
                values: new object[,]
                {
                    { -1, 1 },
                    { -10, 4 },
                    { -7, 4 },
                    { -6, 4 },
                    { -5, 4 },
                    { -4, 4 },
                    { -3, 4 },
                    { -2, 4 },
                    { -10, 3 },
                    { -7, 3 },
                    { -10, 2 },
                    { -7, 2 },
                    { -4, 2 },
                    { -10, 1 },
                    { -7, 1 },
                    { -6, 1 },
                    { -5, 1 },
                    { -4, 1 },
                    { -3, 1 },
                    { -2, 1 },
                    { -8, 5 },
                    { -9, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CelebrityJobTitles_JobTitleId",
                table: "CelebrityJobTitles",
                column: "JobTitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CelebrityJobTitles");

            migrationBuilder.DropTable(
                name: "Celebrities");

            migrationBuilder.DropTable(
                name: "JobTitles");
        }
    }
}

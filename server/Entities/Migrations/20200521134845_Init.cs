using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class Init : Migration
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
                    CelebrityPicURL = table.Column<string>(nullable: true)
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
                    Job = table.Column<string>(nullable: true)
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
                columns: new[] { "CelebrityId", "CelebrityPicURL", "CountViews", "FirstName", "LastName" },
                values: new object[,]
                {
                    { -1, "", 121000, "Уилл", "Смит" },
                    { -2, "", 134000, "Хью", "Джекман" },
                    { -3, "", 127000, "Райан", "Рейнольдс" },
                    { -4, "", 126000, "Роберт", "Дауни (младший)" }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "JobTitleId", "Job" },
                values: new object[,]
                {
                    { 1, "Actor" },
                    { 2, "Writer" },
                    { 3, "Director" },
                    { 4, "Composer" },
                    { 5, "Cinematographer" },
                    { 6, "Producer" }
                });

            migrationBuilder.InsertData(
                table: "CelebrityJobTitles",
                columns: new[] { "CelebrityId", "JobTitleId" },
                values: new object[,]
                {
                    { -1, 1 },
                    { -2, 1 },
                    { -3, 1 },
                    { -1, 3 },
                    { -1, 6 },
                    { -3, 6 }
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

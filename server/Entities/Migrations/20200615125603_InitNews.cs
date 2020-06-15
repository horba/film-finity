using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class InitNews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    NewsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NewsTitle = table.Column<string>(nullable: true),
                    NewsContent = table.Column<string>(nullable: true),
                    CountViews = table.Column<int>(nullable: false),
                    ImageSource = table.Column<string>(nullable: true),
                    PublishTime = table.Column<DateTime>(nullable: false),
                    AuthorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.NewsId);
                    table.ForeignKey(
                        name: "FK_News_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NewsCategories",
                columns: table => new
                {
                    NewsId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewsCategories", x => new { x.CategoryId, x.NewsId });
                    table.ForeignKey(
                        name: "FK_NewsCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NewsCategories_News_NewsId",
                        column: x => x.NewsId,
                        principalTable: "News",
                        principalColumn: "NewsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorName" },
                values: new object[,]
                {
                    { 1, "Мария Колосова" },
                    { 2, "Пабло Мироненкл" },
                    { 3, "Мия Набу" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Variety" },
                    { 2, "FilmNews" }
                });

            migrationBuilder.InsertData(
                table: "News",
                columns: new[] { "NewsId", "AuthorId", "CountViews", "ImageSource", "NewsContent", "NewsTitle", "PublishTime" },
                values: new object[,]
                {
                    { 1, 1, 233, "StaticFiles/images/News/1.jfif", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.", "Сиквел «Чудо-женщины» перенесли из-за коронавируса", new DateTime(2020, 6, 15, 15, 56, 2, 552, DateTimeKind.Local).AddTicks(6130) },
                    { 4, 1, 878, "StaticFiles/images/News/4.jfif", "«Фильм Про» впервые обнародовал Абсолютный топ продаж российских онлайн-кинотеатров и видеосервисов. В условиях, когда из-за коронавируса домашний просмотр набирает популярность, «Фильм Про» первым среди профессиональных киноизданий ", "Фильмы онлайн: Абсолютный топ «Фильм Про»", new DateTime(2020, 6, 15, 15, 56, 2, 555, DateTimeKind.Local).AddTicks(364) },
                    { 2, 2, 512, "StaticFiles/images/News/2.jfif", "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.", "Childish Gambino официально опубликовал новый альбом", new DateTime(2020, 6, 15, 15, 56, 2, 555, DateTimeKind.Local).AddTicks(314) },
                    { 3, 3, 237, "StaticFiles/images/News/3.jfif", "В Сети появился трейлер второго сезона анимационного сериала DС «Харли Квинн». В центре сюжета вновь окажется Харли Квинн и её команда антигероев. После того, как героиня... расстаётся с Джокером, она становится самостоятельной единицей преступного мира и наводит.Lorem ipsum dolor sit amet, consectetur adipisicing elit. Facilis ea veritatis voluptates veniam sunt unde quibusdam modi laboriosam deleniti quod, minima vero nobis! Cumque natus ipsum ab incidunt qui corrupti quis, sit, voluptas, nisi reprehenderit itaque reiciendis. Quo optio itaque minima in numquam officiis odit minus tempora ut error cumque magni voluptate velit rem ullam quidem maiores esse, sint nostrum aliquid, explicabo at! Aspernatur quibusdam consequuntur officia quasi molestiae doloribus sed quaerat mollitia pariatur eius distinctio nesciunt ratione sunt vitae recusandae illum, voluptatibus sit atque consequatur facere aliquam. Itaque eos, atque excepturi illo soluta consectetur, amet minus reiciendis, ipsa velit dignissimos quidem quo doloremque adipisci sed ratione quae minima aut? Inventore est rerum libero, corrupti, id impedit molestiae excepturi omnis facere fugiat iste a amet, earum necessitatibus dolores delectus molestias voluptatem voluptates odio. Nulla, soluta! Quod ex veniam nihil nobis consequuntur repellendus expedita eligendi cumque rem, modi itaque asperiores incidunt eos velit placeat sint dolores. Incidunt cupiditate, alias dolor officia accusantium sed eius doloremque voluptatibus nesciunt nam, ipsum, soluta culpa quod quam possimus? Dolore quasi, dignissimos quam tenetur delectus unde velit, expedita excepturi laboriosam est, consectetur cumque reiciendis facilis nemo similique ea pariatur suscipit repellendus dolor? Pariatur libero cupiditate sint.", "Больше, жестче, грубее: Вышел трейлер второго сезона «Харли Квинн»", new DateTime(2020, 6, 15, 15, 56, 2, 555, DateTimeKind.Local).AddTicks(359) }
                });

            migrationBuilder.InsertData(
                table: "NewsCategories",
                columns: new[] { "CategoryId", "NewsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 1, 2 },
                    { 2, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_News_AuthorId",
                table: "News",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_NewsCategories_NewsId",
                table: "NewsCategories",
                column: "NewsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewsCategories");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "News");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}

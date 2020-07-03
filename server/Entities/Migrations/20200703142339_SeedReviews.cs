using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class SeedReviews : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 17, 23, 38, 531, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 17, 23, 38, 533, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 17, 23, 38, 533, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 17, 23, 38, 533, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "ActorsRating", "ContentType", "DirectingRating", "FilmId", "PlotRating", "PublishTime", "ReviewContent", "ReviewTitle", "SpectacleRating", "UserId" },
                values: new object[,]
                {
                    { 1, 2.6f, 1, 1.6f, 1, 3f, new DateTime(2020, 7, 3, 17, 23, 38, 534, DateTimeKind.Local).AddTicks(8033), "Фильм повествует о 4-х сестрах: Мег (Эмма Уотсон), Джо (Сирша Ронан), Бет (Элайза Сканлен) и Эми(Флоренс Пью).Каждая из сестер имеет свой необычныйхарактер,и каждая мне полюбилась по своему.Самая старшая и женственная Мег, видно какой она серьезной бывает, думая о своем будущем и заботясь о сестренках. Джо — с мальчишеским характером и духом писателя,эта девушка прямолинейна и может  высказать своему собеседнику все что думает о нем.Явно отличается от своих сестер, а что самое интересное, для того времени совсем не думает о замужестве) Считая, чтоженщина вполне сама себя может обеспечить.Бет — скромная и тихая девушка, она любитмузыку и когда играет на фортепиано, все затихают, дабы послушать ее", "Аэронафтика как смысл жизни", 5f, 1 },
                    { 2, 2.6f, 1, 1.6f, 2, 3f, new DateTime(2020, 7, 3, 17, 23, 38, 535, DateTimeKind.Local).AddTicks(158), "Фильм повествует о 4-х сестрах: Мег (Эмма Уотсон), Джо (Сирша Ронан), Бет (Элайза Сканлен) и Эми(Флоренс Пью).Каждая из сестер имеет свой необычныйхарактер,и каждая мне полюбилась по своему.Самая старшая и женственная Мег, видно какой она серьезной бывает, думая о своем будущем и заботясь о сестренках. Джо — с мальчишеским характером и духом писателя,эта девушка прямолинейна и может  высказать своему собеседнику все что думает о нем.Явно отличается от своих сестер, а что самое интересное, для того времени совсем не думает о замужестве) Считая, чтоженщина вполне сама себя может обеспечить.Бет — скромная и тихая девушка, она любитмузыку и когда играет на фортепиано, все затихают, дабы послушать ее", "Аэронафтика как смысл жизни", 5f, 1 },
                    { 3, 2.6f, 0, 1.6f, 1, 3f, new DateTime(2020, 7, 3, 17, 23, 38, 535, DateTimeKind.Local).AddTicks(200), "Фильм повествует о 4-х сестрах: Мег (Эмма Уотсон), Джо (Сирша Ронан), Бет (Элайза Сканлен) и Эми(Флоренс Пью).Каждая из сестер имеет свой необычныйхарактер,и каждая мне полюбилась по своему.Самая старшая и женственная Мег, видно какой она серьезной бывает, думая о своем будущем и заботясь о сестренках. Джо — с мальчишеским характером и духом писателя,эта девушка прямолинейна и может  высказать своему собеседнику все что думает о нем.Явно отличается от своих сестер, а что самое интересное, для того времени совсем не думает о замужестве) Считая, чтоженщина вполне сама себя может обеспечить.Бет — скромная и тихая девушка, она любитмузыку и когда играет на фортепиано, все затихают, дабы послушать ее", "Аэронафтика как смысл жизни", 5f, 1 },
                    { 4, 2.6f, 0, 1.6f, 2, 3f, new DateTime(2020, 7, 3, 17, 23, 38, 535, DateTimeKind.Local).AddTicks(203), "Фильм повествует о 4-х сестрах: Мег (Эмма Уотсон), Джо (Сирша Ронан), Бет (Элайза Сканлен) и Эми(Флоренс Пью).Каждая из сестер имеет свой необычныйхарактер,и каждая мне полюбилась по своему.Самая старшая и женственная Мег, видно какой она серьезной бывает, думая о своем будущем и заботясь о сестренках. Джо — с мальчишеским характером и духом писателя,эта девушка прямолинейна и может  высказать своему собеседнику все что думает о нем.Явно отличается от своих сестер, а что самое интересное, для того времени совсем не думает о замужестве) Считая, чтоженщина вполне сама себя может обеспечить.Бет — скромная и тихая девушка, она любитмузыку и когда играет на фортепиано, все затихают, дабы послушать ее", "Аэронафтика как смысл жизни", 5f, 1 },
                    { 5, 2.6f, 0, 1.6f, 3, 3f, new DateTime(2020, 7, 3, 17, 23, 38, 535, DateTimeKind.Local).AddTicks(207), "Фильм повествует о 4-х сестрах: Мег (Эмма Уотсон), Джо (Сирша Ронан), Бет (Элайза Сканлен) и Эми(Флоренс Пью).Каждая из сестер имеет свой необычныйхарактер,и каждая мне полюбилась по своему.Самая старшая и женственная Мег, видно какой она серьезной бывает, думая о своем будущем и заботясь о сестренках. Джо — с мальчишеским характером и духом писателя,эта девушка прямолинейна и может  высказать своему собеседнику все что думает о нем.Явно отличается от своих сестер, а что самое интересное, для того времени совсем не думает о замужестве) Считая, чтоженщина вполне сама себя может обеспечить.Бет — скромная и тихая девушка, она любитмузыку и когда играет на фортепиано, все затихают, дабы послушать ее", "Аэронафтика как смысл жизни", 5f, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 177, DateTimeKind.Local).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 7, 3, 16, 54, 6, 179, DateTimeKind.Local).AddTicks(7131));
        }
    }
}

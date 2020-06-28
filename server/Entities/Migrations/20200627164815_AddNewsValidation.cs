using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Entities.Migrations
{
    public partial class AddNewsValidation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PreviewImage",
                table: "News",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "PreviewImage",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "News",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 2000);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20);

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 1,
                column: "PublishTime",
                value: new DateTime(2020, 6, 26, 22, 46, 3, 209, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 2,
                column: "PublishTime",
                value: new DateTime(2020, 6, 26, 22, 46, 3, 211, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 3,
                column: "PublishTime",
                value: new DateTime(2020, 6, 26, 22, 46, 3, 211, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "News",
                keyColumn: "Id",
                keyValue: 4,
                column: "PublishTime",
                value: new DateTime(2020, 6, 26, 22, 46, 3, 211, DateTimeKind.Local).AddTicks(9545));
        }
    }
}

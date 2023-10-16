using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pri.Drinks.Infrastructure.Migrations
{
    public partial class AddImage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Drinks",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 10, 16, 12, 22, 10, 897, DateTimeKind.Utc).AddTicks(8574));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Drinks");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Drinks",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3062));

            migrationBuilder.UpdateData(
                table: "Properties",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2023, 9, 18, 14, 27, 35, 855, DateTimeKind.Utc).AddTicks(3063));
        }
    }
}

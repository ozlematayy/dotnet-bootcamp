using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotnetBootcamp.Repository.Migrations
{
    public partial class inital1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9218));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9227));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9495));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9497));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 25, 18, 21, 46, 823, DateTimeKind.Local).AddTicks(9498));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(7836));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(7837));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2023, 12, 21, 0, 29, 58, 457, DateTimeKind.Local).AddTicks(8149));
        }
    }
}

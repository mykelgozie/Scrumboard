using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace serviceslibrary.Migrations
{
    public partial class addseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cartegories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Pending");

            migrationBuilder.InsertData(
                table: "Cartegories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Normal" });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2021, 2, 14, 9, 8, 11, 518, DateTimeKind.Local).AddTicks(4322));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cartegories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Cartegories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Completed");

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                column: "DueDate",
                value: new DateTime(2021, 2, 12, 3, 4, 15, 937, DateTimeKind.Local).AddTicks(5454));
        }
    }
}

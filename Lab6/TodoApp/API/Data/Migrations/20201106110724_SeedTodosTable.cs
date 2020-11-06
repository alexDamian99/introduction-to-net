using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Data.Migrations
{
    public partial class SeedTodosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDone" },
                values: new object[] { 1, new DateTime(2020, 11, 6, 13, 7, 23, 775, DateTimeKind.Local).AddTicks(9631), "tema ml", true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDone" },
                values: new object[] { 2, new DateTime(2020, 11, 6, 13, 7, 23, 780, DateTimeKind.Local).AddTicks(7378), "tema si", false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDone" },
                values: new object[] { 3, new DateTime(2020, 11, 6, 13, 7, 23, 780, DateTimeKind.Local).AddTicks(7673), "tema ai", false });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}

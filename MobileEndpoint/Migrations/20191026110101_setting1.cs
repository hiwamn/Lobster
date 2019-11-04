using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class setting1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1c248836-4ead-4d43-9710-5368452a9c52"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("69557479-7d0b-4f8f-8601-b97cf52f90be"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6a90564a-c018-4409-90ff-244a1e349fa6"), " " });

            migrationBuilder.InsertData(
                table: "Setting",
                columns: new[] { "Id", "Description", "Name", "Value" },
                values: new object[,]
                {
                    { 1, "", "AdNo", "" },
                    { 2, "", "AdDelay", "" },
                    { 3, "", "SpecialNo", "" },
                    { 4, "", "SpecialNumberOfDays", "" },
                    { 5, "", "ImmediateNo", "" },
                    { 6, "", "ImmediateNumberOfDays", "" },
                    { 7, "", "SimplePrice", "" },
                    { 8, "", "ImmediatePrice", "" },
                    { 9, "", "SpecialPrice", "" },
                    { 10, "", "AdPrice", "" }
                });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("00491dc6-7773-4247-97d3-cc73dd4042c1"), " ", "Mobile", 1, "Mobile User" },
                    { new Guid("aaa583df-a1a3-4063-87e9-04aac53f6821"), " ", "Admin", 2, "General Manager" },
                    { new Guid("d9109893-0bbf-45be-b915-969e420ff350"), " ", "Panel", 3, "Panel User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("00491dc6-7773-4247-97d3-cc73dd4042c1"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("aaa583df-a1a3-4063-87e9-04aac53f6821"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d9109893-0bbf-45be-b915-969e420ff350"), " " });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("6a90564a-c018-4409-90ff-244a1e349fa6"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("69557479-7d0b-4f8f-8601-b97cf52f90be"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("1c248836-4ead-4d43-9710-5368452a9c52"), " ", "Panel", 3, "Panel User" });
        }
    }
}

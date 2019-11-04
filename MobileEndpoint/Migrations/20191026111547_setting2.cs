using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class setting2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تعداد آگهی های تبلیغاتی", "10" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تاخیر اسلاید به ثانیه", "2" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تعداد آگهی های ویژه", "30" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تعداد روز آگهی های ویژه", "10" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تعداد آگهی های فوری", "1000000" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Value" },
                values: new object[] { "تعداد روز آگهی های فوری", "30" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Value" },
                values: new object[] { "قیمت آگهی معمولی", "0" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Value" },
                values: new object[] { "قیمت آگهی فوری", "5" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Value" },
                values: new object[] { "قیمت آگهی ویژه", "10" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Value" },
                values: new object[] { "قیمت آگهی تبلیغاتی", "50" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("bdcdea75-cfb5-49b0-a10f-984dc2b63285"), " ", "Mobile", 1, "Mobile User" },
                    { new Guid("f77be083-70b8-4d5c-bf64-4b1428a98eae"), " ", "Admin", 2, "General Manager" },
                    { new Guid("75b7c68a-9772-40fa-a822-965c21bf6fc3"), " ", "Panel", 3, "Panel User" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("75b7c68a-9772-40fa-a822-965c21bf6fc3"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("bdcdea75-cfb5-49b0-a10f-984dc2b63285"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f77be083-70b8-4d5c-bf64-4b1428a98eae"), " " });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Setting",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Value" },
                values: new object[] { "", "" });

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
    }
}

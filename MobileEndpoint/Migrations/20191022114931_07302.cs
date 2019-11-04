using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07302 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("86201490-7546-4f74-8b4f-5c90305c520c"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("dd9cbdf4-20b4-40be-8c9f-c2e60e468e6e"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e1b54237-440b-4fa9-9b4d-a0b4eae9fc7a"), " " });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("46344f0c-e97a-4330-8818-f95d1618b296"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("d47fcd51-fd21-4f52-8814-48bf4dfacea3"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("a71ff6c6-c83c-463d-9e32-446344888425"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("46344f0c-e97a-4330-8818-f95d1618b296"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a71ff6c6-c83c-463d-9e32-446344888425"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d47fcd51-fd21-4f52-8814-48bf4dfacea3"), " " });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("dd9cbdf4-20b4-40be-8c9f-c2e60e468e6e"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("86201490-7546-4f74-8b4f-5c90305c520c"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("e1b54237-440b-4fa9-9b4d-a0b4eae9fc7a"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

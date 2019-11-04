using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07304 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_xUser_UserId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("8ca22439-f678-4843-96f5-c367a0d21554"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("ae3bc3e6-a96c-4d45-af71-20dd49860d7a"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("e9ab003e-ef6c-44e1-b428-3e4f6d6da41f"), " " });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("6b272469-b180-41ff-8a4c-e8cc74af412c"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("04a27021-9f91-4aa4-8548-fbe22129a1a9"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("45f39a1c-d98a-43c2-9cbb-8e6db3496b99"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_xUser_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_xUser_UserId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("04a27021-9f91-4aa4-8548-fbe22129a1a9"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("45f39a1c-d98a-43c2-9cbb-8e6db3496b99"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("6b272469-b180-41ff-8a4c-e8cc74af412c"), " " });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("ae3bc3e6-a96c-4d45-af71-20dd49860d7a"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("e9ab003e-ef6c-44e1-b428-3e4f6d6da41f"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("8ca22439-f678-4843-96f5-c367a0d21554"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_Product_xUser_UserId",
                table: "Product",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

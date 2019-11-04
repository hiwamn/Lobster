using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07305 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct");

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
                values: new object[] { new Guid("7264b505-5a33-4ee9-85c5-00dbd4187b65"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("f0857418-02bf-45a6-8c98-49e589faf8c4"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("df63a046-e2f3-462a-a904-f83ae7718929"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct",
                column: "ProductId",
                principalTable: "Product",
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
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_xUser_UserId",
                table: "MarkedProduct");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("7264b505-5a33-4ee9-85c5-00dbd4187b65"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("df63a046-e2f3-462a-a904-f83ae7718929"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f0857418-02bf-45a6-8c98-49e589faf8c4"), " " });

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
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_LastVisitedProduct_xUser_UserId",
                table: "LastVisitedProduct",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct",
                column: "ProductId",
                principalTable: "Product",
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

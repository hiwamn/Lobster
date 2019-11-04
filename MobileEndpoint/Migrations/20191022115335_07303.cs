using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07303 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
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
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct");

            migrationBuilder.DropForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct");

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
                name: "FK_LastVisitedProduct_Product_ProductId",
                table: "LastVisitedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MarkedProduct_Product_ProductId",
                table: "MarkedProduct",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

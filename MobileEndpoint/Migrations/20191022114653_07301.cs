using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07301 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("670b82b1-af0c-4074-9d91-49825b477888"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("a7737410-3982-4531-8312-ea36d96e9631"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("cf8f7b83-88c6-49f1-920d-e5da70130c7c"), " " });

            migrationBuilder.CreateTable(
                name: "LastVisitedProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LastVisitedProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LastVisitedProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_LastVisitedProduct_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MarkedProduct",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MarkedProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MarkedProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MarkedProduct_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_LastVisitedProduct_ProductId",
                table: "LastVisitedProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_LastVisitedProduct_UserId",
                table: "LastVisitedProduct",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkedProduct_ProductId",
                table: "MarkedProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MarkedProduct_UserId",
                table: "MarkedProduct",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LastVisitedProduct");

            migrationBuilder.DropTable(
                name: "MarkedProduct");

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
                values: new object[] { new Guid("670b82b1-af0c-4074-9d91-49825b477888"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("cf8f7b83-88c6-49f1-920d-e5da70130c7c"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("a7737410-3982-4531-8312-ea36d96e9631"), " ", "Panel", 3, "Panel User" });
        }
    }
}

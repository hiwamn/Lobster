using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07306 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Image_ImageId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_xRoleClaim_xRole_RoleId",
                table: "xRoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserClaim_xUser_UserId",
                table: "xUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserLogin_xUser_UserId",
                table: "xUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserRole_xRole_RoleId",
                table: "xUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserRole_xUser_UserId",
                table: "xUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserToken_xUser_UserId",
                table: "xUserToken");

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
                values: new object[] { new Guid("3d24f820-5457-4783-ade9-ad9a10d34ff7"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("fa4f2b6a-c116-4f64-b6b6-c2e6e93b1c87"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("2c6a3b03-c9f5-4d70-ae45-e791914f6c3e"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Image_ImageId",
                table: "ProductImage",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xRoleClaim_xRole_RoleId",
                table: "xRoleClaim",
                column: "RoleId",
                principalTable: "xRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserClaim_xUser_UserId",
                table: "xUserClaim",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserLogin_xUser_UserId",
                table: "xUserLogin",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserRole_xRole_RoleId",
                table: "xUserRole",
                column: "RoleId",
                principalTable: "xRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserRole_xUser_UserId",
                table: "xUserRole",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserToken_xUser_UserId",
                table: "xUserToken",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Image_ImageId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_xRoleClaim_xRole_RoleId",
                table: "xRoleClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserClaim_xUser_UserId",
                table: "xUserClaim");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserLogin_xUser_UserId",
                table: "xUserLogin");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserRole_xRole_RoleId",
                table: "xUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserRole_xUser_UserId",
                table: "xUserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_xUserToken_xUser_UserId",
                table: "xUserToken");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("2c6a3b03-c9f5-4d70-ae45-e791914f6c3e"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("3d24f820-5457-4783-ade9-ad9a10d34ff7"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("fa4f2b6a-c116-4f64-b6b6-c2e6e93b1c87"), " " });

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
                name: "FK_ProductImage_Image_ImageId",
                table: "ProductImage",
                column: "ImageId",
                principalTable: "Image",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xRoleClaim_xRole_RoleId",
                table: "xRoleClaim",
                column: "RoleId",
                principalTable: "xRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserClaim_xUser_UserId",
                table: "xUserClaim",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserLogin_xUser_UserId",
                table: "xUserLogin",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserRole_xRole_RoleId",
                table: "xUserRole",
                column: "RoleId",
                principalTable: "xRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserRole_xUser_UserId",
                table: "xUserRole",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_xUserToken_xUser_UserId",
                table: "xUserToken",
                column: "UserId",
                principalTable: "xUser",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

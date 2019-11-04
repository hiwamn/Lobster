using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07291 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveCode",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Mobile = table.Column<string>(maxLength: 11, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Location = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Province",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Province", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Update",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Version = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Restricted = table.Column<bool>(nullable: false),
                    Link = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Update", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "xRole",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    No = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Province_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Province",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xRoleClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xRoleClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_xRoleClaim_xRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "xRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xUser",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    FamilyName = table.Column<string>(nullable: true),
                    RegisterDate = table.Column<long>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_xUser_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Device",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    PushId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Device", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Device_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    IsSpecial = table.Column<bool>(nullable: false),
                    IsImmediate = table.Column<bool>(nullable: false),
                    IsAdvertisement = table.Column<bool>(nullable: false),
                    IsForSale = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_City_CityId",
                        column: x => x.CityId,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xUserClaim",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<Guid>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xUserClaim", x => x.Id);
                    table.ForeignKey(
                        name: "FK_xUserClaim_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xUserLogin",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xUserLogin", x => x.UserId);
                    table.UniqueConstraint("AK_xUserLogin_LoginProvider_ProviderKey", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_xUserLogin_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xUserRole",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    RoleId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_xUserRole_xRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "xRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_xUserRole_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "xUserToken",
                columns: table => new
                {
                    UserId = table.Column<Guid>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_xUserToken", x => x.UserId);
                    table.UniqueConstraint("AK_xUserToken_UserId_LoginProvider_Name", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_xUserToken_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Text = table.Column<string>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false),
                    DeviceId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notification_Device_DeviceId",
                        column: x => x.DeviceId,
                        principalTable: "Device",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notification_xUser_UserId",
                        column: x => x.UserId,
                        principalTable: "xUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false),
                    ProductId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImage_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ProductImage_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "همه" },
                    { 2, "کوهنوردی" },
                    { 3, "طبیعت گردی" },
                    { 4, "سنگنوردی" },
                    { 5, "غار نوردی" },
                    { 6, "یخ نوردی" },
                    { 7, "دیواره نوردی" }
                });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("670b82b1-af0c-4074-9d91-49825b477888"), " ", "Mobile", 1, "Mobile User" },
                    { new Guid("cf8f7b83-88c6-49f1-920d-e5da70130c7c"), " ", "Admin", 2, "General Manager" },
                    { new Guid("a7737410-3982-4531-8312-ea36d96e9631"), " ", "Panel", 3, "Panel User" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_ProvinceId",
                table: "City",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Device_UserId",
                table: "Device",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_DeviceId",
                table: "Notification",
                column: "DeviceId");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserId",
                table: "Notification",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CityId",
                table: "Product",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductCategoryId",
                table: "Product",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_UserId",
                table: "Product",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ImageId",
                table: "ProductImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImage",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "xRole",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_xRoleClaim_RoleId",
                table: "xRoleClaim",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_xUser_CityId",
                table: "xUser",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "xUser",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "xUser",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_xUserClaim_UserId",
                table: "xUserClaim",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_xUserRole_RoleId",
                table: "xUserRole",
                column: "RoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActiveCode");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "ProductImage");

            migrationBuilder.DropTable(
                name: "Update");

            migrationBuilder.DropTable(
                name: "xRoleClaim");

            migrationBuilder.DropTable(
                name: "xUserClaim");

            migrationBuilder.DropTable(
                name: "xUserLogin");

            migrationBuilder.DropTable(
                name: "xUserRole");

            migrationBuilder.DropTable(
                name: "xUserToken");

            migrationBuilder.DropTable(
                name: "Device");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "xRole");

            migrationBuilder.DropTable(
                name: "ProductCategory");

            migrationBuilder.DropTable(
                name: "xUser");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Province");
        }
    }
}

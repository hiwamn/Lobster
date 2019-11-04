using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class knowledge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("17a30d61-09d7-49de-8015-9a8f8c6ad37a"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("d943585f-d8e7-43aa-9289-14a9ffc4d59b"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("dea35290-257f-4283-ad02-91f87a82965f"), " " });

            migrationBuilder.AddColumn<double>(
                name: "Humidity",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Pressure",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Temp",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TempMax",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TempMin",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WindDegree",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "WindSpeed",
                table: "WeatherPoint",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "Knowledge",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knowledge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KnowledgeImage",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    RegisterDate = table.Column<long>(nullable: false),
                    ImageId = table.Column<Guid>(nullable: false),
                    KnowledgeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KnowledgeImage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KnowledgeImage_Image_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Image",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KnowledgeImage_Knowledge_KnowledgeId",
                        column: x => x.KnowledgeId,
                        principalTable: "Knowledge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("4639f9e2-16eb-418e-a63e-6dceb44c1c1f"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("f7b8fd57-1aa4-4386-8cb7-acd28267821b"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("985618e6-1ba2-43be-b643-742a6d0c6a85"), " ", "Panel", 3, "Panel User" });

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgeImage_ImageId",
                table: "KnowledgeImage",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_KnowledgeImage_KnowledgeId",
                table: "KnowledgeImage",
                column: "KnowledgeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KnowledgeImage");

            migrationBuilder.DropTable(
                name: "Knowledge");

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("4639f9e2-16eb-418e-a63e-6dceb44c1c1f"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("985618e6-1ba2-43be-b643-742a6d0c6a85"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("f7b8fd57-1aa4-4386-8cb7-acd28267821b"), " " });

            migrationBuilder.DropColumn(
                name: "Humidity",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "Pressure",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "Temp",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "TempMax",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "TempMin",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "WindDegree",
                table: "WeatherPoint");

            migrationBuilder.DropColumn(
                name: "WindSpeed",
                table: "WeatherPoint");

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("d943585f-d8e7-43aa-9289-14a9ffc4d59b"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("17a30d61-09d7-49de-8015-9a8f8c6ad37a"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("dea35290-257f-4283-ad02-91f87a82965f"), " ", "Panel", 3, "Panel User" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class weather : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("23e1d167-8816-4d02-946b-734e9bbc963d"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("2ce72f34-7ef0-4e3c-962b-b9fe59488121"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("b5eb3e27-4863-43bc-a329-62bf849d0165"), " " });

            migrationBuilder.CreateTable(
                name: "WeatherPoint",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Lat = table.Column<double>(nullable: false),
                    Lon = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeatherPoint", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeatherPoint");

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

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("2ce72f34-7ef0-4e3c-962b-b9fe59488121"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("b5eb3e27-4863-43bc-a329-62bf849d0165"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("23e1d167-8816-4d02-946b-734e9bbc963d"), " ", "Panel", 3, "Panel User" });
        }
    }
}

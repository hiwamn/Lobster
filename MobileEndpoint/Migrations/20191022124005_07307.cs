using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MobileEndpoint.Migrations
{
    public partial class _07307 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("c7755a2e-b12b-4a68-b3b3-ba13a59bd4e3"), " ", "Mobile", 1, "Mobile User" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("8790150e-0c49-458d-b96b-6c5bd735ad65"), " ", "Admin", 2, "General Manager" });

            migrationBuilder.InsertData(
                table: "xRole",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "No", "NormalizedName" },
                values: new object[] { new Guid("1c51b71e-0cef-4400-890a-559d5e3e158f"), " ", "Panel", 3, "Panel User" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("1c51b71e-0cef-4400-890a-559d5e3e158f"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("8790150e-0c49-458d-b96b-6c5bd735ad65"), " " });

            migrationBuilder.DeleteData(
                table: "xRole",
                keyColumns: new[] { "Id", "ConcurrencyStamp" },
                keyValues: new object[] { new Guid("c7755a2e-b12b-4a68-b3b3-ba13a59bd4e3"), " " });

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
        }
    }
}

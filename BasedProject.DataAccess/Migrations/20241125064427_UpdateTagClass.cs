using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class UpdateTagClass : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsageCount",
                table: "Tags",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 6, 44, 26, 851, DateTimeKind.Utc).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 6, 44, 26, 851, DateTimeKind.Utc).AddTicks(6524));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 6, 44, 26, 851, DateTimeKind.Utc).AddTicks(6523));

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug", "UsageCount" },
                values: new object[,]
                {
                    { new Guid("027981c1-0880-4e96-b0f7-8cbba916401c"), "C#", "c-sharp", 100 },
                    { new Guid("0ec39fa8-edae-4d2f-a48b-1701288d3d8d"), "Technology", "technology", 150 },
                    { new Guid("3b27b18d-6cdb-42e7-921b-d45c4a8d93f1"), "Web Development", "web-development", 70 },
                    { new Guid("5fd95ff2-6b1f-49ab-95a2-7bfe71465ea4"), "ASP.NET", "asp-net", 80 },
                    { new Guid("a6400f58-77fc-456d-b945-d83cafc70fa1"), "Programming", "programming", 120 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("027981c1-0880-4e96-b0f7-8cbba916401c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("0ec39fa8-edae-4d2f-a48b-1701288d3d8d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3b27b18d-6cdb-42e7-921b-d45c4a8d93f1"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("5fd95ff2-6b1f-49ab-95a2-7bfe71465ea4"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("a6400f58-77fc-456d-b945-d83cafc70fa1"));

            migrationBuilder.DropColumn(
                name: "UsageCount",
                table: "Tags");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1278));
        }
    }
}

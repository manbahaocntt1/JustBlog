using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class UpdateTagClass1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 9, 26, 40, 145, DateTimeKind.Utc).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 9, 26, 40, 145, DateTimeKind.Utc).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 25, 9, 26, 40, 145, DateTimeKind.Utc).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e"),
                column: "UsageCount",
                value: 240);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54"),
                column: "UsageCount",
                value: 270);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803"),
                column: "UsageCount",
                value: 250);

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug", "UsageCount" },
                values: new object[,]
                {
                    { new Guid("2bd29247-6f9c-4460-bc05-22ff27ea0f25"), "ASP.NET", "asp-net", 80 },
                    { new Guid("36bb9f25-5519-49d2-a385-e869b421cd0f"), "Programming", "programming", 120 },
                    { new Guid("d5ec2b1c-a451-41d8-941d-2eddeae45b4c"), "Technology", "technology", 150 },
                    { new Guid("e7860ba8-3785-4307-ad50-9e30e70b2989"), "C#", "c-sharp", 100 },
                    { new Guid("ef6c8927-7317-4e7e-821e-facd8fe57662"), "Web Development", "web-development", 70 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("2bd29247-6f9c-4460-bc05-22ff27ea0f25"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("36bb9f25-5519-49d2-a385-e869b421cd0f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("d5ec2b1c-a451-41d8-941d-2eddeae45b4c"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e7860ba8-3785-4307-ad50-9e30e70b2989"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef6c8927-7317-4e7e-821e-facd8fe57662"));

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

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e"),
                column: "UsageCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54"),
                column: "UsageCount",
                value: null);

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803"),
                column: "UsageCount",
                value: null);

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
    }
}

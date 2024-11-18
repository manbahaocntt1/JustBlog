using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("35782c73-6991-43f6-8e43-2f629194bb71"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6f45cb4f-256e-491a-b317-07047cb18095"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e8ba9f42-e195-43c9-b375-9408b3e4cec3"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("891ecadc-e257-45b5-9538-9c71778145e2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cd316036-e89e-452c-a145-70948262d013"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ef2a6257-3e1b-4a07-869e-795b3e43b719"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a754a3bd-b96f-4baf-b5a0-19e86bb39c78"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b548a8d6-90bc-4646-9010-b3c90da3afb4"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d2735689-c0a5-4be6-b38b-c26d7728a94f"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("bc5c27d7-a794-47ed-bc24-9d99e4d82e76"), "Travel", "travel", "Explore the world" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("c44a7226-670c-4e13-9f2c-9de470fc2ff8"), "Technology", "technology", "All about tech" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("f6f7adfd-8db9-499b-a7c8-80153d4638f8"), "Lifestyle", "lifestyle", "Tips for better living" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc5c27d7-a794-47ed-bc24-9d99e4d82e76"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c44a7226-670c-4e13-9f2c-9de470fc2ff8"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("f6f7adfd-8db9-499b-a7c8-80153d4638f8"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[,]
                {
                    { new Guid("a754a3bd-b96f-4baf-b5a0-19e86bb39c78"), "Lifestyle", "lifestyle", "Tips for better living" },
                    { new Guid("b548a8d6-90bc-4646-9010-b3c90da3afb4"), "Travel", "travel", "Explore the world" },
                    { new Guid("d2735689-c0a5-4be6-b38b-c26d7728a94f"), "Technology", "technology", "All about tech" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("891ecadc-e257-45b5-9538-9c71778145e2"), "ASP.NET", "aspnet" },
                    { new Guid("cd316036-e89e-452c-a145-70948262d013"), "EF Core", "ef-core" },
                    { new Guid("ef2a6257-3e1b-4a07-869e-795b3e43b719"), "C#", "csharp" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("35782c73-6991-43f6-8e43-2f629194bb71"), new Guid("b548a8d6-90bc-4646-9010-b3c90da3afb4"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 10, 36, 22, 287, DateTimeKind.Local).AddTicks(1700), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("6f45cb4f-256e-491a-b317-07047cb18095"), new Guid("a754a3bd-b96f-4baf-b5a0-19e86bb39c78"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 10, 36, 22, 287, DateTimeKind.Local).AddTicks(1698), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("e8ba9f42-e195-43c9-b375-9408b3e4cec3"), new Guid("d2735689-c0a5-4be6-b38b-c26d7728a94f"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 10, 36, 22, 287, DateTimeKind.Local).AddTicks(1686), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });
        }
    }
}

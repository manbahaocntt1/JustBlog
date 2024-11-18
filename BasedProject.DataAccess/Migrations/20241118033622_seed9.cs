using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("6b17d64b-8042-478f-aef1-859aae94b9f2"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("a45fe141-70e2-4e4f-8856-490a3e885502"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d3ddca58-58b5-42cd-81ac-cdd8fc3442c6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("57916fcb-ff02-433d-8dfb-402ac65d3cd6"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("836422c7-7106-4bc3-959c-f5606aba1705"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("8cbad87d-5124-44af-bf79-9d601457d08e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8bf130cf-1fe2-4d82-bd35-6e45d4fa272e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("9336ea9b-b5a2-4025-90fc-3abb4c8735ad"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("960aac15-f0dd-4482-bf99-63d77f5273df"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[,]
                {
                    { new Guid("8bf130cf-1fe2-4d82-bd35-6e45d4fa272e"), "Travel", "travel", "Explore the world" },
                    { new Guid("9336ea9b-b5a2-4025-90fc-3abb4c8735ad"), "Lifestyle", "lifestyle", "Tips for better living" },
                    { new Guid("960aac15-f0dd-4482-bf99-63d77f5273df"), "Technology", "technology", "All about tech" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("57916fcb-ff02-433d-8dfb-402ac65d3cd6"), "EF Core", "ef-core" },
                    { new Guid("836422c7-7106-4bc3-959c-f5606aba1705"), "C#", "csharp" },
                    { new Guid("8cbad87d-5124-44af-bf79-9d601457d08e"), "ASP.NET", "aspnet" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("6b17d64b-8042-478f-aef1-859aae94b9f2"), new Guid("8bf130cf-1fe2-4d82-bd35-6e45d4fa272e"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3705), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("a45fe141-70e2-4e4f-8856-490a3e885502"), new Guid("9336ea9b-b5a2-4025-90fc-3abb4c8735ad"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3704), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("d3ddca58-58b5-42cd-81ac-cdd8fc3442c6"), new Guid("960aac15-f0dd-4482-bf99-63d77f5273df"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 10, 30, 50, 584, DateTimeKind.Local).AddTicks(3695), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed123456789 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"), new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"), new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("c2e3392e-3c79-44d5-9c77-d885c794d753"), new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"), new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"), new Guid("910c43cb-513a-4e88-8022-be1f0c4e51a2") });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("c2e3392e-3c79-44d5-9c77-d885c794d753"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("910c43cb-513a-4e88-8022-be1f0c4e51a2"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5769e55d-129f-4903-be45-5cf3e57d5a0f"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("cd2b0e22-39e7-4665-9104-f8df96e96287"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ffd6c4b1-c9b6-4453-8eb4-9ee6871f87c0"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[,]
                {
                    { new Guid("6f545e35-c323-4387-ba2e-e8f8312f31ed"), "Travel", "travel", "Explore the world" },
                    { new Guid("7352de25-eed2-47da-be78-ffb4c185080a"), "Lifestyle", "lifestyle", "Tips for better living" },
                    { new Guid("d94f809d-4315-47e7-82e2-0699cc3a17dd"), "Technology", "technology", "All about tech" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("52736c63-98e7-4b21-8a03-d191546f5dca"), "ASP.NET", "aspnet" },
                    { new Guid("ae328e27-b4e3-4304-9a50-d5d246489df5"), "EF Core", "ef-core" },
                    { new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806"), "C#", "csharp" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"), new Guid("d94f809d-4315-47e7-82e2-0699cc3a17dd"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 13, 50, 38, 204, DateTimeKind.Local).AddTicks(2695), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"), new Guid("6f545e35-c323-4387-ba2e-e8f8312f31ed"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 13, 50, 38, 204, DateTimeKind.Local).AddTicks(2706), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("df260d11-73bc-4127-a15e-263d4197aa0d"), new Guid("7352de25-eed2-47da-be78-ffb4c185080a"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 13, 50, 38, 204, DateTimeKind.Local).AddTicks(2705), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostsId", "TagsId" },
                values: new object[,]
                {
                    { new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"), new Guid("52736c63-98e7-4b21-8a03-d191546f5dca") },
                    { new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"), new Guid("ae328e27-b4e3-4304-9a50-d5d246489df5") },
                    { new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"), new Guid("52736c63-98e7-4b21-8a03-d191546f5dca") },
                    { new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"), new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806") },
                    { new Guid("df260d11-73bc-4127-a15e-263d4197aa0d"), new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"), new Guid("52736c63-98e7-4b21-8a03-d191546f5dca") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"), new Guid("ae328e27-b4e3-4304-9a50-d5d246489df5") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"), new Guid("52736c63-98e7-4b21-8a03-d191546f5dca") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"), new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("df260d11-73bc-4127-a15e-263d4197aa0d"), new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806") });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("007a1bd0-dd8a-4b82-835a-cd3832db2f09"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("0905af09-1d4c-4b5f-aa5e-775845d60e7a"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("df260d11-73bc-4127-a15e-263d4197aa0d"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("52736c63-98e7-4b21-8a03-d191546f5dca"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ae328e27-b4e3-4304-9a50-d5d246489df5"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("ceeae720-b0c6-4ebd-8cd8-be5d6ac9b806"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f545e35-c323-4387-ba2e-e8f8312f31ed"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7352de25-eed2-47da-be78-ffb4c185080a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("d94f809d-4315-47e7-82e2-0699cc3a17dd"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[,]
                {
                    { new Guid("5769e55d-129f-4903-be45-5cf3e57d5a0f"), "Travel", "travel", "Explore the world" },
                    { new Guid("cd2b0e22-39e7-4665-9104-f8df96e96287"), "Lifestyle", "lifestyle", "Tips for better living" },
                    { new Guid("ffd6c4b1-c9b6-4453-8eb4-9ee6871f87c0"), "Technology", "technology", "All about tech" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555"), "ASP.NET", "aspnet" },
                    { new Guid("910c43cb-513a-4e88-8022-be1f0c4e51a2"), "EF Core", "ef-core" },
                    { new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18"), "C#", "csharp" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"), new Guid("5769e55d-129f-4903-be45-5cf3e57d5a0f"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 13, 38, 26, 301, DateTimeKind.Local).AddTicks(157), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("c2e3392e-3c79-44d5-9c77-d885c794d753"), new Guid("cd2b0e22-39e7-4665-9104-f8df96e96287"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 13, 38, 26, 301, DateTimeKind.Local).AddTicks(156), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"), new Guid("ffd6c4b1-c9b6-4453-8eb4-9ee6871f87c0"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 13, 38, 26, 301, DateTimeKind.Local).AddTicks(147), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostsId", "TagsId" },
                values: new object[,]
                {
                    { new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"), new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555") },
                    { new Guid("8cea09ae-fb8b-4954-8698-50e48582097b"), new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18") },
                    { new Guid("c2e3392e-3c79-44d5-9c77-d885c794d753"), new Guid("b8ec167f-e1ac-4044-9730-d8f5e8ac7c18") },
                    { new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"), new Guid("4b5fe5d1-dff8-4d4c-93d5-84257746b555") },
                    { new Guid("cfd5319e-1af5-4da4-83ca-cd6ff65a4575"), new Guid("910c43cb-513a-4e88-8022-be1f0c4e51a2") }
                });
        }
    }
}

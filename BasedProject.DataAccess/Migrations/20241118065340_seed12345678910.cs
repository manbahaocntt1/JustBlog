using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed12345678910 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("4bc46f19-70f8-47b9-99c8-045ecdc99da2"), "Travel", "travel", "Explore the world" },
                    { new Guid("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9"), "Technology", "technology", "All about tech" },
                    { new Guid("c1a50d85-b239-4281-9de1-4fb911d525cf"), "Lifestyle", "lifestyle", "Tips for better living" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e"), "ASP.NET", "aspnet" },
                    { new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54"), "EF Core", "ef-core" },
                    { new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803"), "C#", "csharp" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 6, 53, 39, 916, DateTimeKind.Utc).AddTicks(8191), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("4bc46f19-70f8-47b9-99c8-045ecdc99da2"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 6, 53, 39, 916, DateTimeKind.Utc).AddTicks(8224), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("f517791a-738e-471c-8f2e-ad18e139038e"), new Guid("c1a50d85-b239-4281-9de1-4fb911d525cf"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 6, 53, 39, 916, DateTimeKind.Utc).AddTicks(8223), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "PostTags",
                columns: new[] { "PostsId", "TagsId" },
                values: new object[,]
                {
                    { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e") },
                    { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54") },
                    { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e") },
                    { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803") },
                    { new Guid("f517791a-738e-471c-8f2e-ad18e139038e"), new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803") });

            migrationBuilder.DeleteData(
                table: "PostTags",
                keyColumns: new[] { "PostsId", "TagsId" },
                keyValues: new object[] { new Guid("f517791a-738e-471c-8f2e-ad18e139038e"), new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803") });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("b7ad3e42-815f-421c-b3b8-4f7a7b94622e"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("c68f7b7d-1dd5-431e-98d1-9eae2e1b8d54"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("e5f20ab3-bf82-482a-a977-6a5c2bbff803"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4bc46f19-70f8-47b9-99c8-045ecdc99da2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c1a50d85-b239-4281-9de1-4fb911d525cf"));

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
    }
}

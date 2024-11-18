using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed1234567 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("971ae68a-9b17-4989-83ab-3943b92d442c"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[,]
                {
                    { new Guid("00c44580-e3ac-4352-95c8-51a968ee79b3"), "Lifestyle", "lifestyle", "Tips for better living" },
                    { new Guid("99433e73-8c2b-4380-98cb-a217e7fc8cae"), "Travel", "travel", "Explore the world" },
                    { new Guid("a8d1fde8-83df-45bd-9307-b60e59926fbe"), "Technology", "technology", "All about tech" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("3a41f8b4-d326-4c8e-9930-e31ff8d2bbbd"), "C#", "csharp" },
                    { new Guid("9f58345a-9cdf-416f-bf76-77cd531d9d5b"), "ASP.NET", "aspnet" },
                    { new Guid("cfd89877-064c-4235-9b1d-a7b229196901"), "EF Core", "ef-core" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("5753b3bb-fe6b-4b19-8458-97af0bfe2c44"), new Guid("00c44580-e3ac-4352-95c8-51a968ee79b3"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4034), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("b3172df0-a087-4ed8-a131-9f5a5f24f1f5"), new Guid("a8d1fde8-83df-45bd-9307-b60e59926fbe"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4021), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("d3d5a837-464c-4fe5-989a-f326aa4e2080"), new Guid("99433e73-8c2b-4380-98cb-a217e7fc8cae"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 13, 35, 10, 274, DateTimeKind.Local).AddTicks(4035), true, "The best places to visit this year", "Top 10 Travel Destinations" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("5753b3bb-fe6b-4b19-8458-97af0bfe2c44"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("b3172df0-a087-4ed8-a131-9f5a5f24f1f5"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("d3d5a837-464c-4fe5-989a-f326aa4e2080"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("3a41f8b4-d326-4c8e-9930-e31ff8d2bbbd"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("9f58345a-9cdf-416f-bf76-77cd531d9d5b"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("cfd89877-064c-4235-9b1d-a7b229196901"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("00c44580-e3ac-4352-95c8-51a968ee79b3"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("99433e73-8c2b-4380-98cb-a217e7fc8cae"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("a8d1fde8-83df-45bd-9307-b60e59926fbe"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("971ae68a-9b17-4989-83ab-3943b92d442c"), "Technology", "technology", "All about tech" });
        }
    }
}

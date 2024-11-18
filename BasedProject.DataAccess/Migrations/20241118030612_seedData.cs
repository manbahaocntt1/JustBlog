using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[,]
                {
                    { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("660d77bf-6ed8-446f-891b-4a486a109214"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6828), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" },
                    { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6840), true, "The best places to visit this year", "Top 10 Travel Destinations" },
                    { new Guid("f517791a-738e-471c-8f2e-ad18e139038e"), new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 10, 6, 12, 97, DateTimeKind.Local).AddTicks(6838), true, "Tips for a healthy lifestyle", "Healthy Living Tips" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName", "TagUrlSlug" },
                values: new object[,]
                {
                    { new Guid("3bdd4c93-1081-4c10-a6ad-bd098a30502f"), "C#", "csharp" },
                    { new Guid("977736af-ec2c-4841-ac31-34280aa64423"), "EF Core", "ef-core" },
                    { new Guid("af23f823-f098-4112-94ef-ff278d3fd217"), "ASP.NET", "aspnet" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("3bdd4c93-1081-4c10-a6ad-bd098a30502f"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("977736af-ec2c-4841-ac31-34280aa64423"));

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: new Guid("af23f823-f098-4112-94ef-ff278d3fd217"));
        }
    }
}

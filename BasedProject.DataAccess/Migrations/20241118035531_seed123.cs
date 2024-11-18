using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"), "Travel", "travel", "Explore the world" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("660d77bf-6ed8-446f-891b-4a486a109214"), "Technology", "technology", "All about tech" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"), "Lifestyle", "lifestyle", "Tips for better living" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("660d77bf-6ed8-446f-891b-4a486a109214"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"));

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
    }
}

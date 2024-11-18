using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed1234 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("17f03e82-f859-486b-ac4a-55844517ae9e"), "Travel", "travel", "Explore the world" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName", "CategoryUrlSlug", "Description" },
                values: new object[] { new Guid("ca2d1bda-dc62-4cc7-a5a1-7487c18cb294"), "Lifestyle", "lifestyle", "Tips for better living" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "TagUrlSlug",
                table: "Tags",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "PostUrlSlug",
                table: "Posts",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                type: "nvarchar(max)",
                maxLength: 102400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 102400);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryUrlSlug",
                table: "Categories",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "TagUrlSlug",
                table: "Tags",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ShortDescription",
                table: "Posts",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostUrlSlug",
                table: "Posts",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostContent",
                table: "Posts",
                type: "nvarchar(max)",
                maxLength: 102400,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldMaxLength: 102400,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CategoryUrlSlug",
                table: "Categories",
                type: "nvarchar(1024)",
                maxLength: 1024,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(1024)",
                oldMaxLength: 1024,
                oldNullable: true);

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
    }
}

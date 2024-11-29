using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CategoryUrlSlug = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TagUrlSlug = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PostContent = table.Column<string>(type: "nvarchar(max)", maxLength: 102400, nullable: false),
                    PostUrlSlug = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    Published = table.Column<bool>(type: "bit", nullable: false),
                    PostedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostTags",
                columns: table => new
                {
                    PostsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TagsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostTags", x => new { x.PostsId, x.TagsId });
                    table.ForeignKey(
                        name: "FK_PostTags_Posts_PostsId",
                        column: x => x.PostsId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PostTags_Tags_TagsId",
                        column: x => x.TagsId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                values: new object[] { new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"), new Guid("bc91bb55-c0f2-4012-a0a7-8b5a5ed626c9"), "ASP.NET is a powerful framework...", "getting-started-aspnet", new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2124), true, "A guide to ASP.NET for beginners", "Getting Started with ASP.NET" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"), new Guid("4bc46f19-70f8-47b9-99c8-045ecdc99da2"), "From beaches to mountains, explore...", "top-travel-destinations", new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2127), true, "The best places to visit this year", "Top 10 Travel Destinations" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "PostContent", "PostUrlSlug", "PostedOn", "Published", "ShortDescription", "Title" },
                values: new object[] { new Guid("f517791a-738e-471c-8f2e-ad18e139038e"), new Guid("c1a50d85-b239-4281-9de1-4fb911d525cf"), "Living a healthy life involves...", "healthy-living-tips", new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2126), true, "Tips for a healthy lifestyle", "Healthy Living Tips" });

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoryId",
                table: "Posts",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PostTags_TagsId",
                table: "PostTags",
                column: "TagsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PostTags");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}

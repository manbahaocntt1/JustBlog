using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasedProject.DataAccess.Migrations
{
    public partial class AddCommentPostField1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RateCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalRate",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ViewCount",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CommentHeader = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CommentText = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    CommentTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1274));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 21, 4, 11, 3, 64, DateTimeKind.Utc).AddTicks(1278));

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostId",
                table: "Comments",
                column: "PostId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropColumn(
                name: "RateCount",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TotalRate",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "ViewCount",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("95b4fcf6-a59b-4477-b815-10262cfea221"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("e3797fba-c8ba-41c2-ad56-4ac68cfaf495"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: new Guid("f517791a-738e-471c-8f2e-ad18e139038e"),
                column: "PostedOn",
                value: new DateTime(2024, 11, 18, 9, 0, 2, 92, DateTimeKind.Utc).AddTicks(2126));
        }
    }
}

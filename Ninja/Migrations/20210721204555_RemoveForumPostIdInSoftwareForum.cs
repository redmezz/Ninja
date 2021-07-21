using Microsoft.EntityFrameworkCore.Migrations;

namespace Ninja.Migrations
{
    public partial class RemoveForumPostIdInSoftwareForum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SoftwareForums_ForumPost_ForumPostId",
                table: "SoftwareForums");

            migrationBuilder.DropIndex(
                name: "IX_SoftwareForums_ForumPostId",
                table: "SoftwareForums");

            migrationBuilder.DropColumn(
                name: "ForumPostId",
                table: "SoftwareForums");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ForumPostId",
                table: "SoftwareForums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SoftwareForums_ForumPostId",
                table: "SoftwareForums",
                column: "ForumPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_SoftwareForums_ForumPost_ForumPostId",
                table: "SoftwareForums",
                column: "ForumPostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

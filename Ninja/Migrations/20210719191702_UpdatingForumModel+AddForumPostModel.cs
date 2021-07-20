using Microsoft.EntityFrameworkCore.Migrations;

namespace Ninja.Migrations
{
    public partial class UpdatingForumModelAddForumPostModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ForumAuthor",
                table: "Forums",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ForumPostId",
                table: "Forums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ForumPost",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NinjaPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ForumPost", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Forums_ForumPostId",
                table: "Forums",
                column: "ForumPostId");

            migrationBuilder.AddForeignKey(
                name: "FK_Forums_ForumPost_ForumPostId",
                table: "Forums",
                column: "ForumPostId",
                principalTable: "ForumPost",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_ForumPost_ForumPostId",
                table: "Forums");

            migrationBuilder.DropTable(
                name: "ForumPost");

            migrationBuilder.DropIndex(
                name: "IX_Forums_ForumPostId",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "ForumAuthor",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "ForumPostId",
                table: "Forums");
        }
    }
}

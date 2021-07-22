using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Ninja.Migrations
{
    public partial class InterfacesAndNewModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Forums_ForumPost_ForumPostId",
                table: "Forums");

            migrationBuilder.DropTable(
                name: "SubForums");

            migrationBuilder.DropIndex(
                name: "IX_Forums_ForumPostId",
                table: "Forums");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumPost",
                table: "ForumPost");

            migrationBuilder.DropColumn(
                name: "ForumAuthor",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "ForumPostId",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "NinjaPoints",
                table: "ForumPost");

            migrationBuilder.RenameTable(
                name: "ForumPost",
                newName: "ForumPosts");

            migrationBuilder.RenameColumn(
                name: "ForumTitle",
                table: "Forums",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "PostTitle",
                table: "ForumPosts",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "ForumPosts",
                newName: "Content");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Forums",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "ForumPosts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ForumId",
                table: "ForumPosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "ForumPosts",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumPosts",
                table: "ForumPosts",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Joined = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PostReplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostReplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostReplies_ForumPosts_PostId",
                        column: x => x.PostId,
                        principalTable: "ForumPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostReplies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_ForumId",
                table: "ForumPosts",
                column: "ForumId");

            migrationBuilder.CreateIndex(
                name: "IX_ForumPosts_UserId",
                table: "ForumPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReplies_PostId",
                table: "PostReplies",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostReplies_UserId",
                table: "PostReplies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ForumPosts_Forums_ForumId",
                table: "ForumPosts",
                column: "ForumId",
                principalTable: "Forums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ForumPosts_Users_UserId",
                table: "ForumPosts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ForumPosts_Forums_ForumId",
                table: "ForumPosts");

            migrationBuilder.DropForeignKey(
                name: "FK_ForumPosts_Users_UserId",
                table: "ForumPosts");

            migrationBuilder.DropTable(
                name: "PostReplies");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ForumPosts",
                table: "ForumPosts");

            migrationBuilder.DropIndex(
                name: "IX_ForumPosts_ForumId",
                table: "ForumPosts");

            migrationBuilder.DropIndex(
                name: "IX_ForumPosts_UserId",
                table: "ForumPosts");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Forums");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "ForumPosts");

            migrationBuilder.DropColumn(
                name: "ForumId",
                table: "ForumPosts");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ForumPosts");

            migrationBuilder.RenameTable(
                name: "ForumPosts",
                newName: "ForumPost");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Forums",
                newName: "ForumTitle");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "ForumPost",
                newName: "PostTitle");

            migrationBuilder.RenameColumn(
                name: "Content",
                table: "ForumPost",
                newName: "Author");

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

            migrationBuilder.AddColumn<int>(
                name: "NinjaPoints",
                table: "ForumPost",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ForumPost",
                table: "ForumPost",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "SubForums",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ForumTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubForums", x => x.Id);
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
    }
}

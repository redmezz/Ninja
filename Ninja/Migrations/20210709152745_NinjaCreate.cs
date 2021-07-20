using Microsoft.EntityFrameworkCore.Migrations;

namespace Ninja.Migrations
{
    public partial class NinjaCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Author",
                table: "ComputerForum");

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "ComputerForum",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ComputerForum_AuthorId",
                table: "ComputerForum",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComputerForum_Users_AuthorId",
                table: "ComputerForum",
                column: "AuthorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComputerForum_Users_AuthorId",
                table: "ComputerForum");

            migrationBuilder.DropIndex(
                name: "IX_ComputerForum_AuthorId",
                table: "ComputerForum");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "ComputerForum");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "ComputerForum",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

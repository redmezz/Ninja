using Microsoft.EntityFrameworkCore.Migrations;

namespace Ninja.Migrations
{
    public partial class ForumAuthorAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ForumAuthor",
                table: "SoftwareForums",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ForumAuthor",
                table: "SoftwareForums");
        }
    }
}

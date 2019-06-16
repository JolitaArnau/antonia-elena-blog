using Microsoft.EntityFrameworkCore.Migrations;

namespace Antonia_Elena_Blog.Migrations
{
    public partial class ChangedUpBlogPostEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PublishedBy",
                table: "BlogPosts");

            migrationBuilder.RenameColumn(
                name: "Subtitle",
                table: "BlogPosts",
                newName: "Writer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Writer",
                table: "BlogPosts",
                newName: "Subtitle");

            migrationBuilder.AddColumn<string>(
                name: "PublishedBy",
                table: "BlogPosts",
                nullable: true);
        }
    }
}

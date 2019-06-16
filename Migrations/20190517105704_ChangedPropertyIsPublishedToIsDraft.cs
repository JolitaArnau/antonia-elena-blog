using Microsoft.EntityFrameworkCore.Migrations;

namespace Antonia_Elena_Blog.Migrations
{
    public partial class ChangedPropertyIsPublishedToIsDraft : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsPublished",
                table: "BlogPosts",
                newName: "IsDraft");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsDraft",
                table: "BlogPosts",
                newName: "IsPublished");
        }
    }
}

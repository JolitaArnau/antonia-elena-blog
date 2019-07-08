using Microsoft.EntityFrameworkCore.Migrations;

namespace Your_Blog_Template.Migrations
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

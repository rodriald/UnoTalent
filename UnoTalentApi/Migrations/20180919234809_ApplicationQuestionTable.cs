using Microsoft.EntityFrameworkCore.Migrations;

namespace UnoTalentApi.Migrations
{
    public partial class ApplicationQuestionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Applications",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Applications");
        }
    }
}

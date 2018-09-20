using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnoTalentApi.Migrations
{
    public partial class NewBasicEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Applications_Aplication",
                table: "Candidates");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_Aplication",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Aplication",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "ApplicationId",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Applications_Id",
                table: "Candidates",
                column: "Id",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Applications_Id",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int))
                .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "Aplication",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ApplicationId",
                table: "Candidates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_Aplication",
                table: "Candidates",
                column: "Aplication",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Applications_Aplication",
                table: "Candidates",
                column: "Aplication",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

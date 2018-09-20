using Microsoft.EntityFrameworkCore.Migrations;

namespace UnoTalentApi.Migrations
{
    public partial class BasicSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Applications_ApplicationId",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_ApplicationId",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Questions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "Candidates",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Aplication",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Candidates_Applications_Aplication",
                table: "Candidates");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Candidates_Aplication",
                table: "Candidates");

            migrationBuilder.DropColumn(
                name: "Aplication",
                table: "Candidates");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Questions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "ApplicationId",
                table: "Candidates",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Candidates_ApplicationId",
                table: "Candidates",
                column: "ApplicationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Candidates_Applications_ApplicationId",
                table: "Candidates",
                column: "ApplicationId",
                principalTable: "Applications",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Categories_CategoryId",
                table: "Questions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

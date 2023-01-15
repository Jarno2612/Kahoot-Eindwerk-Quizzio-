using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddIsCorrectInAnswerAndDescriptionInQuestion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Beschrijving",
                table: "Answer",
                newName: "description");

            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Question",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isCorrect",
                table: "Answer",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Question");

            migrationBuilder.DropColumn(
                name: "isCorrect",
                table: "Answer");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Answer",
                newName: "Beschrijving");
        }
    }
}

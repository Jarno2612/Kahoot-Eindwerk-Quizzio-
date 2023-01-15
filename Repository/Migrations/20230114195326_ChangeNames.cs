using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ChangeNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserGame",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "UserGame",
                newName: "GameId");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Question",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "isCorrect",
                table: "Answer",
                newName: "IsCorrect");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Answer",
                newName: "Description");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserGame",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "UserGame",
                newName: "gameId");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Question",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "IsCorrect",
                table: "Answer",
                newName: "isCorrect");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Answer",
                newName: "description");
        }
    }
}

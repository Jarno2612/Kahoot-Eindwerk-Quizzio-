using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ChangeNameOfUserIdAndGameId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "UserGame",
                newName: "userId");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "UserGame",
                newName: "gameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "userId",
                table: "UserGame",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "gameId",
                table: "UserGame",
                newName: "GameId");
        }
    }
}

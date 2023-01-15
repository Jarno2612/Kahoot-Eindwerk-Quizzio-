using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ChangeTableNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerQuestion_Answers_AnswersId",
                table: "AnswerQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerQuestion_Questions_QuestionId",
                table: "AnswerQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUserGame_Answers_AnswersId",
                table: "AnswerUserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUserGame_UserGames_UserGameId",
                table: "AnswerUserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Users_AdminId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Games_GameId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGames_Games_GameId",
                table: "UserGames");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGames_Users_UserId",
                table: "UserGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGames",
                table: "UserGames");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Games",
                table: "Games");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answers",
                table: "Answers");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "UserGames",
                newName: "UserGame");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "Question");

            migrationBuilder.RenameTable(
                name: "Games",
                newName: "Game");

            migrationBuilder.RenameTable(
                name: "Answers",
                newName: "Answer");

            migrationBuilder.RenameIndex(
                name: "IX_UserGames_UserId",
                table: "UserGame",
                newName: "IX_UserGame_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserGames_GameId",
                table: "UserGame",
                newName: "IX_UserGame_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_GameId",
                table: "Question",
                newName: "IX_Question_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Games_AdminId",
                table: "Game",
                newName: "IX_Game_AdminId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGame",
                table: "UserGame",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Question",
                table: "Question",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Game",
                table: "Game",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answer",
                table: "Answer",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerQuestion_Answer_AnswersId",
                table: "AnswerQuestion",
                column: "AnswersId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerQuestion_Question_QuestionId",
                table: "AnswerQuestion",
                column: "QuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUserGame_Answer_AnswersId",
                table: "AnswerUserGame",
                column: "AnswersId",
                principalTable: "Answer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUserGame_UserGame_UserGameId",
                table: "AnswerUserGame",
                column: "UserGameId",
                principalTable: "UserGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Game_User_AdminId",
                table: "Game",
                column: "AdminId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Game_GameId",
                table: "Question",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGame_Game_GameId",
                table: "UserGame",
                column: "GameId",
                principalTable: "Game",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGame_User_UserId",
                table: "UserGame",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnswerQuestion_Answer_AnswersId",
                table: "AnswerQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerQuestion_Question_QuestionId",
                table: "AnswerQuestion");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUserGame_Answer_AnswersId",
                table: "AnswerUserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_AnswerUserGame_UserGame_UserGameId",
                table: "AnswerUserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_Game_User_AdminId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_Question_Game_GameId",
                table: "Question");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_Game_GameId",
                table: "UserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_User_UserId",
                table: "UserGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserGame",
                table: "UserGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Question",
                table: "Question");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Game",
                table: "Game");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Answer",
                table: "Answer");

            migrationBuilder.RenameTable(
                name: "UserGame",
                newName: "UserGames");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "Question",
                newName: "Questions");

            migrationBuilder.RenameTable(
                name: "Game",
                newName: "Games");

            migrationBuilder.RenameTable(
                name: "Answer",
                newName: "Answers");

            migrationBuilder.RenameIndex(
                name: "IX_UserGame_UserId",
                table: "UserGames",
                newName: "IX_UserGames_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_UserGame_GameId",
                table: "UserGames",
                newName: "IX_UserGames_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Question_GameId",
                table: "Questions",
                newName: "IX_Questions_GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Game_AdminId",
                table: "Games",
                newName: "IX_Games_AdminId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserGames",
                table: "UserGames",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Games",
                table: "Games",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Answers",
                table: "Answers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerQuestion_Answers_AnswersId",
                table: "AnswerQuestion",
                column: "AnswersId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerQuestion_Questions_QuestionId",
                table: "AnswerQuestion",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUserGame_Answers_AnswersId",
                table: "AnswerUserGame",
                column: "AnswersId",
                principalTable: "Answers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnswerUserGame_UserGames_UserGameId",
                table: "AnswerUserGame",
                column: "UserGameId",
                principalTable: "UserGames",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Users_AdminId",
                table: "Games",
                column: "AdminId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Games_GameId",
                table: "Questions",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGames_Games_GameId",
                table: "UserGames",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGames_Users_UserId",
                table: "UserGames",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }
    }
}

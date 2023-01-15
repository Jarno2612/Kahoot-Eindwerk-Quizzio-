using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class deletedAnswerQuestionAndAnswerUserGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnswerUserGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnswerUserGame",
                columns: table => new
                {
                    AnswersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserGameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnswerUserGame", x => new { x.AnswersId, x.UserGameId });
                    table.ForeignKey(
                        name: "FK_AnswerUserGame_Answer_AnswersId",
                        column: x => x.AnswersId,
                        principalTable: "Answer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnswerUserGame_UserGame_UserGameId",
                        column: x => x.UserGameId,
                        principalTable: "UserGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnswerUserGame_UserGameId",
                table: "AnswerUserGame",
                column: "UserGameId");
        }
    }
}

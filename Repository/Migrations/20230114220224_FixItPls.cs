using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class FixItPls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Game_UserGame_UserGameId",
                table: "Game");

            migrationBuilder.DropForeignKey(
                name: "FK_User_UserGame_UserGameId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserGameId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Game_UserGameId",
                table: "Game");

            migrationBuilder.DropColumn(
                name: "UserGameId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserGameId",
                table: "Game");

            migrationBuilder.AddColumn<Guid>(
                name: "GameId1",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId1",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_GameId1",
                table: "UserGame",
                column: "GameId1");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_UserId1",
                table: "UserGame",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGame_Game_GameId1",
                table: "UserGame",
                column: "GameId1",
                principalTable: "Game",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserGame_User_UserId1",
                table: "UserGame",
                column: "UserId1",
                principalTable: "User",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_Game_GameId1",
                table: "UserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_User_UserId1",
                table: "UserGame");

            migrationBuilder.DropIndex(
                name: "IX_UserGame_GameId1",
                table: "UserGame");

            migrationBuilder.DropIndex(
                name: "IX_UserGame_UserId1",
                table: "UserGame");

            migrationBuilder.DropColumn(
                name: "GameId1",
                table: "UserGame");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "UserGame");

            migrationBuilder.AddColumn<Guid>(
                name: "UserGameId",
                table: "User",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserGameId",
                table: "Game",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_UserGameId",
                table: "User",
                column: "UserGameId");

            migrationBuilder.CreateIndex(
                name: "IX_Game_UserGameId",
                table: "Game",
                column: "UserGameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Game_UserGame_UserGameId",
                table: "Game",
                column: "UserGameId",
                principalTable: "UserGame",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_UserGame_UserGameId",
                table: "User",
                column: "UserGameId",
                principalTable: "UserGame",
                principalColumn: "Id");
        }
    }
}

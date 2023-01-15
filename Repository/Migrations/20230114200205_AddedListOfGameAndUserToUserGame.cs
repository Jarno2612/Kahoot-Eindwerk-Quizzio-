using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class AddedListOfGameAndUserToUserGame : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gameId",
                table: "UserGame");

            migrationBuilder.DropColumn(
                name: "userId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "gameId",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "userId",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }
    }
}

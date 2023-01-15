using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class Reversed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_Game_GameId",
                table: "UserGame");

            migrationBuilder.DropForeignKey(
                name: "FK_UserGame_User_UserId",
                table: "UserGame");

            migrationBuilder.DropIndex(
                name: "IX_UserGame_GameId",
                table: "UserGame");

            migrationBuilder.DropIndex(
                name: "IX_UserGame_UserId",
                table: "UserGame");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "UserGame");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserGame");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "GameId",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "UserGame",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_GameId",
                table: "UserGame",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_UserGame_UserId",
                table: "UserGame",
                column: "UserId");

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
    }
}

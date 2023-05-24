using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FifaCardApi.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Player_Cards : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Player_Card_CardId",
                table: "Player");

            migrationBuilder.DropIndex(
                name: "IX_Player_CardId",
                table: "Player");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "Player");

            migrationBuilder.RenameTable(
                name: "Card",
                newName: "Cards");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Cards",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cards",
                table: "Cards",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Player_PlayerId",
                table: "Cards",
                column: "PlayerId",
                principalTable: "Player",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Player_PlayerId",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cards",
                table: "Cards");

            migrationBuilder.DropIndex(
                name: "IX_Cards_PlayerId",
                table: "Cards");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Cards");

            migrationBuilder.RenameTable(
                name: "Cards",
                newName: "Card");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "Player",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Player_CardId",
                table: "Player",
                column: "CardId");

            migrationBuilder.AddForeignKey(
                name: "FK_Player_Card_CardId",
                table: "Player",
                column: "CardId",
                principalTable: "Card",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

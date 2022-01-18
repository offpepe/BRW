using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRW.API.Migrations
{
    public partial class ihrenceTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "championship_played_id",
                table: "users",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "discriminator",
                table: "users",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "ix_users_championship_played_id",
                table: "users",
                column: "championship_played_id");

            migrationBuilder.AddForeignKey(
                name: "fk_users_championship_championship_id2",
                table: "users",
                column: "championship_played_id",
                principalTable: "championship",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_users_championship_championship_id2",
                table: "users");

            migrationBuilder.DropIndex(
                name: "ix_users_championship_played_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "championship_played_id",
                table: "users");

            migrationBuilder.DropColumn(
                name: "discriminator",
                table: "users");
        }
    }
}

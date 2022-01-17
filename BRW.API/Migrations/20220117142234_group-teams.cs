using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRW.API.Migrations
{
    public partial class groupteams : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Teams_GroupId",
                table: "Teams",
                column: "GroupId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Groups_GroupId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_GroupId",
                table: "Teams");
        }
    }
}

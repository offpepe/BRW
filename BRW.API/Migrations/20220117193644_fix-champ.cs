using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRW.API.Migrations
{
    public partial class fixchamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Championship",
                newName: "championship");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "championship",
                newName: "Championship");
        }
    }
}

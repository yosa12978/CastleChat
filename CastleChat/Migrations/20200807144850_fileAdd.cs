using Microsoft.EntityFrameworkCore.Migrations;

namespace CastleChat.Migrations
{
    public partial class fileAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "filePath",
                table: "rooms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "filePath",
                table: "discussions",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "filePath",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "filePath",
                table: "discussions");
        }
    }
}

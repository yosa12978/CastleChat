using Microsoft.EntityFrameworkCore.Migrations;

namespace CastleChat.Migrations
{
    public partial class NewMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_castles_Castleid",
                table: "rooms");

            migrationBuilder.RenameColumn(
                name: "Castleid",
                table: "rooms",
                newName: "castleid");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_Castleid",
                table: "rooms",
                newName: "IX_rooms_castleid");

            migrationBuilder.AlterColumn<long>(
                name: "castleid",
                table: "rooms",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "text",
                table: "rooms",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_castles_castleid",
                table: "rooms",
                column: "castleid",
                principalTable: "castles",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_rooms_castles_castleid",
                table: "rooms");

            migrationBuilder.DropColumn(
                name: "text",
                table: "rooms");

            migrationBuilder.RenameColumn(
                name: "castleid",
                table: "rooms",
                newName: "Castleid");

            migrationBuilder.RenameIndex(
                name: "IX_rooms_castleid",
                table: "rooms",
                newName: "IX_rooms_Castleid");

            migrationBuilder.AlterColumn<long>(
                name: "Castleid",
                table: "rooms",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.AddForeignKey(
                name: "FK_rooms_castles_Castleid",
                table: "rooms",
                column: "Castleid",
                principalTable: "castles",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

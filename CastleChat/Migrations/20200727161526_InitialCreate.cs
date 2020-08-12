using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CastleChat.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "castles",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_castles", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    username = table.Column<string>(nullable: false),
                    password = table.Column<string>(nullable: false),
                    regDate = table.Column<DateTime>(nullable: false),
                    icon = table.Column<string>(nullable: false),
                    token = table.Column<string>(nullable: false),
                    role = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "rooms",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(nullable: false),
                    authorid = table.Column<long>(nullable: false),
                    Castleid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rooms", x => x.id);
                    table.ForeignKey(
                        name: "FK_rooms_castles_Castleid",
                        column: x => x.Castleid,
                        principalTable: "castles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_rooms_users_authorid",
                        column: x => x.authorid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "discussions",
                columns: table => new
                {
                    id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    text = table.Column<string>(nullable: false),
                    authorid = table.Column<long>(nullable: false),
                    pubDate = table.Column<DateTime>(nullable: false),
                    roomid = table.Column<long>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    discussionid = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_discussions", x => x.id);
                    table.ForeignKey(
                        name: "FK_discussions_users_authorid",
                        column: x => x.authorid,
                        principalTable: "users",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_discussions_rooms_roomid",
                        column: x => x.roomid,
                        principalTable: "rooms",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_discussions_discussions_discussionid",
                        column: x => x.discussionid,
                        principalTable: "discussions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_discussions_authorid",
                table: "discussions",
                column: "authorid");

            migrationBuilder.CreateIndex(
                name: "IX_discussions_roomid",
                table: "discussions",
                column: "roomid");

            migrationBuilder.CreateIndex(
                name: "IX_discussions_discussionid",
                table: "discussions",
                column: "discussionid");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_Castleid",
                table: "rooms",
                column: "Castleid");

            migrationBuilder.CreateIndex(
                name: "IX_rooms_authorid",
                table: "rooms",
                column: "authorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "discussions");

            migrationBuilder.DropTable(
                name: "rooms");

            migrationBuilder.DropTable(
                name: "castles");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}

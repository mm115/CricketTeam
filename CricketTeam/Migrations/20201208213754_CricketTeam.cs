using System;
using System.IO;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CricketTeam.Migrations
{
    public partial class CricketTeam : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Player_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_Name = table.Column<string>(nullable: true),
                    Player_Address = table.Column<string>(nullable: true),
                    Player_Mobile = table.Column<string>(nullable: true),
                    Player_Email = table.Column<string>(nullable: true),
                    Player_Age = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Player_Id);
                });

            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Fixture_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    vs_Team = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Ground_Name = table.Column<string>(nullable: true),
                    Player_ID = table.Column<int>(nullable: false),
                    Player_objPlayer_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Fixture_Id);
                    table.ForeignKey(
                        name: "FK_Fixtures_Players_Player_objPlayer_Id",
                        column: x => x.Player_objPlayer_Id,
                        principalTable: "Players",
                        principalColumn: "Player_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ranking",
                columns: table => new
                {
                    Ranking_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Player_Name = table.Column<string>(nullable: true),
                    Test = table.Column<string>(nullable: true),
                    ODI = table.Column<string>(nullable: true),
                    T20 = table.Column<string>(nullable: true),
                    Player_ID = table.Column<int>(nullable: false),
                    Player_objPlayer_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ranking", x => x.Ranking_Id);
                    table.ForeignKey(
                        name: "FK_Ranking_Players_Player_objPlayer_Id",
                        column: x => x.Player_objPlayer_Id,
                        principalTable: "Players",
                        principalColumn: "Player_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Event_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ICC_WTC = table.Column<string>(nullable: true),
                    IPL = table.Column<string>(nullable: true),
                    T20_WC = table.Column<string>(nullable: true),
                    Fixture_ID = table.Column<int>(nullable: false),
                    Fixture_objFixture_Id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Event_Id);
                    table.ForeignKey(
                        name: "FK_Events_Fixtures_Fixture_objFixture_Id",
                        column: x => x.Fixture_objFixture_Id,
                        principalTable: "Fixtures",
                        principalColumn: "Fixture_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_Fixture_objFixture_Id",
                table: "Events",
                column: "Fixture_objFixture_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_Player_objPlayer_Id",
                table: "Fixtures",
                column: "Player_objPlayer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Ranking_Player_objPlayer_Id",
                table: "Ranking",
                column: "Player_objPlayer_Id");
            var sqlFile = Path.Combine(".\\DatabaseScript", @"Query.sql");
            migrationBuilder.Sql(File.ReadAllText(sqlFile));

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "Ranking");

            migrationBuilder.DropTable(
                name: "Fixtures");

            migrationBuilder.DropTable(
                name: "Players");
        }
    }
}

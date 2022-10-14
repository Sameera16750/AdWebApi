using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class trophyWithTeamTable2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_TEAM_WITH_TROPHY",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    trophyid = table.Column<long>(type: "bigint", nullable: true),
                    teamid = table.Column<long>(type: "bigint", nullable: true),
                    maxPrice = table.Column<double>(type: "double", nullable: false),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TEAM_WITH_TROPHY", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_TEAM_WITH_TROPHY_T_TEAMS_teamid",
                        column: x => x.teamid,
                        principalTable: "T_TEAMS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TEAM_WITH_TROPHY_T_TROPHY_trophyid",
                        column: x => x.trophyid,
                        principalTable: "T_TROPHY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_WITH_TROPHY_teamid",
                table: "T_TEAM_WITH_TROPHY",
                column: "teamid");

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_WITH_TROPHY_trophyid",
                table: "T_TEAM_WITH_TROPHY",
                column: "trophyid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_TEAM_WITH_TROPHY");
        }
    }
}

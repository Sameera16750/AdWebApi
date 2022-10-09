using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class intTeamOwnerAndTeamTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_TEAMS",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TEAMS", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_TEAM_OWNER",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    contactNo = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    nic = table.Column<string>(type: "text", nullable: false),
                    teamid = table.Column<long>(type: "bigint", nullable: true),
                    userid = table.Column<long>(type: "bigint", nullable: true),
                    createddate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TEAM_OWNER", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_TEAM_OWNER_T_TEAMS_teamid",
                        column: x => x.teamid,
                        principalTable: "T_TEAMS",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_TEAM_OWNER_T_USER_userid",
                        column: x => x.userid,
                        principalTable: "T_USER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_OWNER_teamid",
                table: "T_TEAM_OWNER",
                column: "teamid");

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_OWNER_userid",
                table: "T_TEAM_OWNER",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_TEAM_OWNER");

            migrationBuilder.DropTable(
                name: "T_TEAMS");
        }
    }
}

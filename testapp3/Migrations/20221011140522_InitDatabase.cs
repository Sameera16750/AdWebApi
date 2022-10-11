using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class InitDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_EMPLOYEE",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    EmployeeName = table.Column<string>(type: "text", nullable: false),
                    EmployeeAge = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_EMPLOYEE", x => x.EmployeeID);
                });

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
                name: "T_TROPHY",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    startDate = table.Column<string>(type: "text", nullable: false),
                    endDate = table.Column<string>(type: "text", nullable: false),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_TROPHY", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_USER_TYPES",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    type = table.Column<string>(type: "text", nullable: false),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    isDashBoardEnabled = table.Column<int>(type: "int", nullable: false),
                    isViewPlayerEnabled = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER_TYPES", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "T_USER",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    password = table.Column<string>(type: "text", nullable: false),
                    typeid = table.Column<long>(type: "bigint", nullable: true),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastupdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_USER_T_USER_TYPES_typeid",
                        column: x => x.typeid,
                        principalTable: "T_USER_TYPES",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_INSIDE_USERS",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    contactNo = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    userid = table.Column<long>(type: "bigint", nullable: true),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_INSIDE_USERS", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_INSIDE_USERS_T_USER_userid",
                        column: x => x.userid,
                        principalTable: "T_USER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "T_PLAYER",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    age = table.Column<int>(type: "int", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    contactNo = table.Column<string>(type: "text", nullable: false),
                    address = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "text", nullable: false),
                    nic = table.Column<string>(type: "text", nullable: false),
                    userid = table.Column<long>(type: "bigint", nullable: true),
                    createddate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PLAYER", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_PLAYER_T_USER_userid",
                        column: x => x.userid,
                        principalTable: "T_USER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
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

            migrationBuilder.CreateTable(
                name: "T_PAYER_WITH_TROPHY",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    playerid = table.Column<long>(type: "bigint", nullable: true),
                    trophyid = table.Column<long>(type: "bigint", nullable: true),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_PAYER_WITH_TROPHY", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_PAYER_WITH_TROPHY_T_PLAYER_playerid",
                        column: x => x.playerid,
                        principalTable: "T_PLAYER",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_T_PAYER_WITH_TROPHY_T_TROPHY_trophyid",
                        column: x => x.trophyid,
                        principalTable: "T_TROPHY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_INSIDE_USERS_userid",
                table: "T_INSIDE_USERS",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_T_PAYER_WITH_TROPHY_playerid",
                table: "T_PAYER_WITH_TROPHY",
                column: "playerid");

            migrationBuilder.CreateIndex(
                name: "IX_T_PAYER_WITH_TROPHY_trophyid",
                table: "T_PAYER_WITH_TROPHY",
                column: "trophyid");

            migrationBuilder.CreateIndex(
                name: "IX_T_PLAYER_userid",
                table: "T_PLAYER",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_OWNER_teamid",
                table: "T_TEAM_OWNER",
                column: "teamid");

            migrationBuilder.CreateIndex(
                name: "IX_T_TEAM_OWNER_userid",
                table: "T_TEAM_OWNER",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_typeid",
                table: "T_USER",
                column: "typeid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_EMPLOYEE");

            migrationBuilder.DropTable(
                name: "T_INSIDE_USERS");

            migrationBuilder.DropTable(
                name: "T_PAYER_WITH_TROPHY");

            migrationBuilder.DropTable(
                name: "T_TEAM_OWNER");

            migrationBuilder.DropTable(
                name: "T_PLAYER");

            migrationBuilder.DropTable(
                name: "T_TROPHY");

            migrationBuilder.DropTable(
                name: "T_TEAMS");

            migrationBuilder.DropTable(
                name: "T_USER");

            migrationBuilder.DropTable(
                name: "T_USER_TYPES");
        }
    }
}

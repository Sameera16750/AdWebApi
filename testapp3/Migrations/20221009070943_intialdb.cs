using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class intialdb : Migration
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

            migrationBuilder.CreateIndex(
                name: "IX_T_INSIDE_USERS_userid",
                table: "T_INSIDE_USERS",
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
                name: "T_USER");

            migrationBuilder.DropTable(
                name: "T_USER_TYPES");
        }
    }
}

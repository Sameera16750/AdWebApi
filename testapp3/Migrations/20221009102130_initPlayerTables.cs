using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class initPlayerTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_T_PLAYER_userid",
                table: "T_PLAYER",
                column: "userid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_PLAYER");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace testapp3.Migrations
{
    public partial class biddingTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_BIDDING",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    playerid = table.Column<long>(type: "bigint", nullable: true),
                    lastBidderId = table.Column<long>(type: "bigint", nullable: false),
                    startingPrice = table.Column<double>(type: "double", nullable: false),
                    endPrice = table.Column<double>(type: "double", nullable: false),
                    createdDate = table.Column<string>(type: "text", nullable: false),
                    lastUpdate = table.Column<string>(type: "text", nullable: false),
                    status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_BIDDING", x => x.id);
                    table.ForeignKey(
                        name: "FK_T_BIDDING_T_PAYER_WITH_TROPHY_playerid",
                        column: x => x.playerid,
                        principalTable: "T_PAYER_WITH_TROPHY",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_BIDDING_playerid",
                table: "T_BIDDING",
                column: "playerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_BIDDING");
        }
    }
}

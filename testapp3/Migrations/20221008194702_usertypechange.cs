using Microsoft.EntityFrameworkCore.Migrations;

namespace testapp3.Migrations
{
    public partial class usertypechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isDashBoardEnabled",
                table: "T_USER_TYPES",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isDashBoardEnabled",
                table: "T_USER_TYPES");
        }
    }
}

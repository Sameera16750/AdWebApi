using Microsoft.EntityFrameworkCore.Migrations;

namespace testapp3.Migrations
{
    public partial class usertypechangeEnableplayerview : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "isViewPlayerEnabled",
                table: "T_USER_TYPES",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isViewPlayerEnabled",
                table: "T_USER_TYPES");
        }
    }
}

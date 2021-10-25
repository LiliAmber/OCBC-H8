using Microsoft.EntityFrameworkCore.Migrations;

namespace TodoAppJWT.Migrations
{
    public partial class updaterefreshtokenstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRevokerked",
                table: "RefreshTokens",
                newName: "IsRevorked");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsRevorked",
                table: "RefreshTokens",
                newName: "IsRevokerked");
        }
    }
}

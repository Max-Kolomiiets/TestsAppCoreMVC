using Microsoft.EntityFrameworkCore.Migrations;

namespace TestsAppCoreMVC.Data.Migrations
{
    public partial class edituser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

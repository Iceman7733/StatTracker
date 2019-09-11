using Microsoft.EntityFrameworkCore.Migrations;

namespace StatTrackerAPI.Migrations
{
    public partial class AddRosterName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Roster",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Roster");
        }
    }
}

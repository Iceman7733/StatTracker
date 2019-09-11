using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace StatTrackerAPI.Migrations
{
    public partial class Int : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Roster",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roster", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RosterId = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PlateAppearances = table.Column<int>(nullable: false),
                    AtBats = table.Column<int>(nullable: false),
                    Hits = table.Column<int>(nullable: false),
                    Doubles = table.Column<int>(nullable: false),
                    Triples = table.Column<int>(nullable: false),
                    HomeRuns = table.Column<int>(nullable: false),
                    Runs = table.Column<int>(nullable: false),
                    RBIs = table.Column<int>(nullable: false),
                    StolenBases = table.Column<int>(nullable: false),
                    StrikeOuts = table.Column<int>(nullable: false),
                    BattingAverage = table.Column<double>(nullable: false),
                    OnBasePercentage = table.Column<double>(nullable: false),
                    SluggingPercentage = table.Column<double>(nullable: false),
                    OnBasePlusSlugging = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Players_Roster_RosterId",
                        column: x => x.RosterId,
                        principalTable: "Roster",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_RosterId",
                table: "Players",
                column: "RosterId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Roster");
        }
    }
}

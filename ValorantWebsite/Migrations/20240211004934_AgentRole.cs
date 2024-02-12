using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ValorantWebsite.Migrations
{
    /// <inheritdoc />
    public partial class AgentRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgentRoles",
                columns: table => new
                {
                    AgentRoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    AgentRoleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgentRoles", x => x.AgentRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Maps",
                columns: table => new
                {
                    MapID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MapName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MapImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimapImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maps", x => x.MapID);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    WeaponID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeaponType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreditCost = table.Column<int>(type: "int", nullable: true),
                    WeaponImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FireMode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FireRatePerSec = table.Column<double>(type: "float", nullable: true),
                    RunSpeedPerSec = table.Column<double>(type: "float", nullable: false),
                    ReloadSpeedPerSec = table.Column<double>(type: "float", nullable: true),
                    MagazineSize = table.Column<int>(type: "int", nullable: true),
                    ReserveSize = table.Column<int>(type: "int", nullable: true),
                    Damage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.WeaponID);
                });

            migrationBuilder.InsertData(
                table: "AgentRoles",
                columns: new[] { "AgentRoleId", "AgentRoleName" },
                values: new object[,]
                {
                    { "Cont", "Controller" },
                    { "Duel", "Duelist" },
                    { "Init", "Initiator" },
                    { "Sent", "Sentinel" }
                });

            migrationBuilder.InsertData(
                table: "Maps",
                columns: new[] { "MapID", "MapImage", "MapLocation", "MapName", "MinimapImage" },
                values: new object[,]
                {
                    { "asce", "Loading_Screen_Ascent.png", "Venice, Italy", "Ascent", "Ascent_Minimap.png" },
                    { "bind", "Loading_Screen_Bind.png", "Rabat, Morocco", "Bind", "Bind_Minimap.png" },
                    { "bree", "Loading_Screen_Breeze.png", "Bermuda Triangle, Atlantic Ocean", "Breeze", "Breeze_Minimap.png" },
                    { "frac", "Loading_Screen_Fracture.png", "Santa Fe County, New Mexico, USA", "Fracture", "Fracture_Minimap.png" },
                    { "have", "Loading_Screen_Haven.png", "Thimphu, Bhutan", "Haven", "Haven_Minimap.png" },
                    { "iceb", "Loading_Screen_Icebox.png", "Bennett Island, Russia", "Icebox", "Icebox_Minimap.png" },
                    { "lotu", "Loading_Screen_Lotus.png", "Western Ghats, India", "Lotus", "Lotus_Minimap.png" },
                    { "pear", "Loading_Screen_Pearl.png", "Lisbon, Portugal", "Pearl", "Pearl_Minimap.png" },
                    { "spli", "Loading_Screen_Split.png", "Tokyo, Japan", "Split", "Split_Minimap.png" },
                    { "suns", "Loading_Screen_Sunset.png", "Los Angeles, California, USA", "Sunset", "Sunset_Minimap.png" }
                });

            migrationBuilder.InsertData(
                table: "Weapons",
                columns: new[] { "WeaponID", "CreditCost", "Damage", "FireMode", "FireRatePerSec", "MagazineSize", "ReloadSpeedPerSec", "ReserveSize", "RunSpeedPerSec", "WeaponImage", "WeaponName", "WeaponType" },
                values: new object[] { 1, 0, 0, "Semi-Automatic", 6.75, 12, 1.75, 36, 5.7300000000000004, "Classic.png", "Classic", "Sidearm" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgentRoles");

            migrationBuilder.DropTable(
                name: "Maps");

            migrationBuilder.DropTable(
                name: "Weapons");
        }
    }
}

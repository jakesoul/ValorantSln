using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ValorantWebsite.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QAbility = table.Column<string>(name: "Q_Ability", type: "nvarchar(max)", nullable: false),
                    EAbility = table.Column<string>(name: "E_Ability", type: "nvarchar(max)", nullable: false),
                    CAbility = table.Column<string>(name: "C_Ability", type: "nvarchar(max)", nullable: false),
                    XAbility = table.Column<string>(name: "X_Ability", type: "nvarchar(max)", nullable: false),
                    Biography = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");
        }
    }
}

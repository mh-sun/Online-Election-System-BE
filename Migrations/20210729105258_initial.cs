using Microsoft.EntityFrameworkCore.Migrations;

namespace ElectionSys.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Candidates",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    symbol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vote_count = table.Column<int>(type: "int", nullable: false),
                    e_id = table.Column<int>(type: "int", nullable: false),
                    e_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Candidates", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Elections",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    c_id = table.Column<int>(type: "int", nullable: false),
                    winner = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    freeze_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    publish_status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elections", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Voters",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date_of_birth = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    voted = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voters", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "id", "fullname", "password", "username" },
                values: new object[] { 1, "Institute Of Information Technology", "123", "iit" });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "id", "fullname", "password", "username" },
                values: new object[] { 2, "Mehedi Hasan Sun", "123", "mehedi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Candidates");

            migrationBuilder.DropTable(
                name: "Elections");

            migrationBuilder.DropTable(
                name: "Voters");
        }
    }
}

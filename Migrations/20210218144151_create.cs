using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomatedFactory.Migrations
{
    public partial class create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tagliaferro",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Misuraferro = table.Column<int>(type: "int", nullable: false),
                    TipoMetallo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Filettatura = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tagliaferro", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tagliaferro");
        }
    }
}

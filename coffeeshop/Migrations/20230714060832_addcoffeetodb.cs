using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coffeeshop.Migrations
{
    public partial class addcoffeetodb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "coffeetbl",
                columns: table => new
                {
                    coffeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    coffeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quatity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_coffeetbl", x => x.coffeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "coffeetbl");
        }
    }
}

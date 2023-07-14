using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coffeeshop.Migrations
{
    public partial class addcoffeetodb1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quatity",
                table: "coffeetbl",
                newName: "quantity");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "quantity",
                table: "coffeetbl",
                newName: "quatity");
        }
    }
}

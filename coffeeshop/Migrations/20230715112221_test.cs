using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace coffeeshop.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "coffeeId",
                table: "coffeetbl",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "coffeetbl",
                newName: "coffeeId");
        }
    }
}

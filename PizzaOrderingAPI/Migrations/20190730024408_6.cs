using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingAPI.Migrations
{
    public partial class _6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PizzaId",
                table: "Order");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PizzaId",
                table: "Order",
                nullable: false,
                defaultValue: 0);
        }
    }
}

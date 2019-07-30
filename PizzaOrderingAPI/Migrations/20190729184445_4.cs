using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingAPI.Migrations
{
    public partial class _4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payment_Customer_CustomerId",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Payment",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Payment",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CustomerId",
                table: "Payment",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_Customer_CustomerId",
                table: "Payment",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingAPI.Migrations
{
    public partial class databasechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_CheeseAmount_CheeseAmountid",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Crust_Crustid",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Order_OrderId",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_SauceAmount_SauceAmountid",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Sauce_Sauceid",
                table: "Pizza");

            migrationBuilder.DropForeignKey(
                name: "FK_Pizza_Size_Sizeid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_CheeseAmountid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_Crustid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_OrderId",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_SauceAmountid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_Sauceid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Pizza_Sizeid",
                table: "Pizza");

            migrationBuilder.DropIndex(
                name: "IX_Order_CustomerId",
                table: "Order");

            migrationBuilder.RenameColumn(
                name: "Sizeid",
                table: "Pizza",
                newName: "SizeId");

            migrationBuilder.RenameColumn(
                name: "Sauceid",
                table: "Pizza",
                newName: "SauceId");

            migrationBuilder.RenameColumn(
                name: "SauceAmountid",
                table: "Pizza",
                newName: "SauceAmountId");

            migrationBuilder.RenameColumn(
                name: "Crustid",
                table: "Pizza",
                newName: "CrustId");

            migrationBuilder.RenameColumn(
                name: "CheeseAmountid",
                table: "Pizza",
                newName: "CheeseAmountId");

            migrationBuilder.AlterColumn<int>(
                name: "SizeId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SauceId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SauceAmountId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CrustId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CheeseAmountId",
                table: "Pizza",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Order",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SizeId",
                table: "Pizza",
                newName: "Sizeid");

            migrationBuilder.RenameColumn(
                name: "SauceId",
                table: "Pizza",
                newName: "Sauceid");

            migrationBuilder.RenameColumn(
                name: "SauceAmountId",
                table: "Pizza",
                newName: "SauceAmountid");

            migrationBuilder.RenameColumn(
                name: "CrustId",
                table: "Pizza",
                newName: "Crustid");

            migrationBuilder.RenameColumn(
                name: "CheeseAmountId",
                table: "Pizza",
                newName: "CheeseAmountid");

            migrationBuilder.AlterColumn<int>(
                name: "Sizeid",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Sauceid",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "SauceAmountid",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Crustid",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CheeseAmountid",
                table: "Pizza",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Order",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_CheeseAmountid",
                table: "Pizza",
                column: "CheeseAmountid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_Crustid",
                table: "Pizza",
                column: "Crustid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_OrderId",
                table: "Pizza",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_SauceAmountid",
                table: "Pizza",
                column: "SauceAmountid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_Sauceid",
                table: "Pizza",
                column: "Sauceid");

            migrationBuilder.CreateIndex(
                name: "IX_Pizza_Sizeid",
                table: "Pizza",
                column: "Sizeid");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Customer_CustomerId",
                table: "Order",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_CheeseAmount_CheeseAmountid",
                table: "Pizza",
                column: "CheeseAmountid",
                principalTable: "CheeseAmount",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Crust_Crustid",
                table: "Pizza",
                column: "Crustid",
                principalTable: "Crust",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Order_OrderId",
                table: "Pizza",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_SauceAmount_SauceAmountid",
                table: "Pizza",
                column: "SauceAmountid",
                principalTable: "SauceAmount",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Sauce_Sauceid",
                table: "Pizza",
                column: "Sauceid",
                principalTable: "Sauce",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pizza_Size_Sizeid",
                table: "Pizza",
                column: "Sizeid",
                principalTable: "Size",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

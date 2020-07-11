using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class data2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_orders_OrderID",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "OrderID",
                table: "products",
                newName: "OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_products_OrderID",
                table: "products",
                newName: "IX_products_OrderId");

            migrationBuilder.AlterColumn<int>(
                name: "OrderId",
                table: "products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_orders_OrderId",
                table: "products",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_orders_OrderId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "OrderId",
                table: "products",
                newName: "OrderID");

            migrationBuilder.RenameIndex(
                name: "IX_products_OrderId",
                table: "products",
                newName: "IX_products_OrderID");

            migrationBuilder.AlterColumn<int>(
                name: "OrderID",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_products_orders_OrderID",
                table: "products",
                column: "OrderID",
                principalTable: "orders",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

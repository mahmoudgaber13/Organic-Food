using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class UpdateOrderdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "OrderDetailsID",
                table: "products",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "orders",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_OrderDetailsID",
                table: "products",
                column: "OrderDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_products_OrderDetails_OrderDetailsID",
                table: "products",
                column: "OrderDetailsID",
                principalTable: "OrderDetails",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_OrderDetails_OrderDetailsID",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_OrderDetailsID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "OrderDetailsID",
                table: "products");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "orders");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

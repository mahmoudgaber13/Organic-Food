using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class orderDetailsupdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderDetails",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

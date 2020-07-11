using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class orderDetailsupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails");

            migrationBuilder.AlterColumn<int>(
                name: "ProductID",
                table: "OrderDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "products",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
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
                nullable: true,
                oldClrType: typeof(int));

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

using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class ModelLastUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "orders",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Contacts",
                type: "nvarchar(500)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_orders_UserID",
                table: "orders",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_AspNetUsers_UserID",
                table: "orders",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_AspNetUsers_UserID",
                table: "orders");

            migrationBuilder.DropIndex(
                name: "IX_orders_UserID",
                table: "orders");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "orders");

            migrationBuilder.AlterColumn<string>(
                name: "Text",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldNullable: true);
        }
    }
}

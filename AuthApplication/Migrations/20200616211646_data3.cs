using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthApplication.Migrations
{
    public partial class data3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "orders");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

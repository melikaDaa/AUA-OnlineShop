using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "OrderId",
                schema: "sh",
                table: "Basket");
            migrationBuilder.DropColumn(
                name: "BasketId",
                schema: "sh",
                table: "Basket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

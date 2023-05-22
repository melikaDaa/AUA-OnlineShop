using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class basketmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BasketId",
                schema: "sh",
                table: "Basket",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "OrderId",
                schema: "sh",
                table: "Basket");
        }
    }
}

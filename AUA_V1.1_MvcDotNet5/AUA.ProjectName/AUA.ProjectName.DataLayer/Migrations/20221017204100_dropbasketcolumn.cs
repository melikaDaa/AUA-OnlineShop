using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class dropbasketcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Productid",
                schema: "sh",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "Cookie",
                schema: "sh",
                table: "Basket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
          
        }
    }
}

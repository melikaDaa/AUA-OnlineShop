using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class dropcolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

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

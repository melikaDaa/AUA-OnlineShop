using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.WebUI.Migrations
{
    public partial class mydbcartmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Basket_Product_ProductId",
                schema: "sh",
                table: "Basket");

            migrationBuilder.DropIndex(
                name: "IX_Basket_ProductId",
                schema: "sh",
                table: "Basket");

            migrationBuilder.DropColumn(
                name: "ProductId",
                schema: "sh",
                table: "Basket");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                schema: "sh",
                table: "Basket",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ProductId",
                schema: "sh",
                table: "Basket",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Basket_Product_ProductId",
                schema: "sh",
                table: "Basket",
                column: "ProductId",
                principalSchema: "sh",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

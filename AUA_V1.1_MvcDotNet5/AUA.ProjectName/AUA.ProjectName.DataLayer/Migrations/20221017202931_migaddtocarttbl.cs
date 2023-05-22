using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class migaddtocarttbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basket",
                schema: "sh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    DateBought = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsFinaly = table.Column<bool>(type: "bit", nullable: false),
                    OrderSum = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false,
                        defaultValueSql: "GetDate()"),
                    Userid = table.Column<int>(type: "int", nullable: false)
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
        


            migrationBuilder.CreateTable(
                name: "BasketDetails",
                schema: "sh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2(3)", nullable: false, defaultValueSql: "GetDate()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Basket_OrderId",
                        column: x => x.OrderId,
                        principalSchema: "sh",
                        principalTable: "Basket",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasketDetails_Product_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "sh",
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_ProductId",
                schema: "sh",
                table: "Basket",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_Userid",
                schema: "sh",
                table: "Basket",
                column: "Userid");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_OrderId",
                schema: "sh",
                table: "BasketDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketDetails_ProductId",
                schema: "sh",
                table: "BasketDetails",
                column: "ProductId");
            migrationBuilder.DropTable(
                name: "Basket",
                schema: "sh");
        }
    }
}

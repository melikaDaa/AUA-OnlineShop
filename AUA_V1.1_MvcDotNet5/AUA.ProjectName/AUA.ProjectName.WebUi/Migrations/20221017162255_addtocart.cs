using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.WebUI.Migrations
{
    public partial class addtocart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductDto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Authorid = table.Column<int>(type: "int", nullable: false),
                    Categoryid = table.Column<int>(type: "int", nullable: false),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    IntroductionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    PriceProduct = table.Column<int>(type: "int", nullable: false),
                    PublishYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TitleProduct = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductDto_Author_Authorid",
                        column: x => x.Authorid,
                        principalSchema: "sh",
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductDto_Category_Categoryid",
                        column: x => x.Categoryid,
                        principalSchema: "sh",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductDto_Authorid",
                table: "ProductDto",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDto_Categoryid",
                table: "ProductDto",
                column: "Categoryid");
        }
    }
}

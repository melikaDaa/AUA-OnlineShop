using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.WebUI.Migrations
{
    public partial class MyMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "sh");

            migrationBuilder.CreateTable(
                name: "Author",
                schema: "sh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "sh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "sh",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    IntroductionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    PublishYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Publishers = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoryid = table.Column<int>(type: "int", nullable: false),
                    Authorid = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Author_Authorid",
                        column: x => x.Authorid,
                        principalSchema: "sh",
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Category_Categoryid",
                        column: x => x.Categoryid,
                        principalSchema: "sh",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductDto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountProduct = table.Column<int>(type: "int", nullable: false),
                    IntroductionProduct = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PriceProduct = table.Column<int>(type: "int", nullable: false),
                    NumberOfPages = table.Column<int>(type: "int", nullable: false),
                    PublishYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Categoryid = table.Column<int>(type: "int", nullable: false),
                    Authorid = table.Column<int>(type: "int", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                name: "IX_Product_Authorid",
                schema: "sh",
                table: "Product",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Categoryid",
                schema: "sh",
                table: "Product",
                column: "Categoryid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDto_Authorid",
                table: "ProductDto",
                column: "Authorid");

            migrationBuilder.CreateIndex(
                name: "IX_ProductDto_Categoryid",
                table: "ProductDto",
                column: "Categoryid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product",
                schema: "sh");

            migrationBuilder.DropTable(
                name: "ProductDto");

            migrationBuilder.DropTable(
                name: "Author",
                schema: "sh");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "sh");
        }
    }
}

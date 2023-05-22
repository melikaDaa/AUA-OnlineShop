using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class basektmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderSum",
                schema: "sh",
                table: "Basket",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinaly",
                schema: "sh",
                table: "Basket",
                nullable: true);


        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}

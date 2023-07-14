using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzapanDataAccessLayer.Migrations
{
    public partial class mig_discount_add_entityy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UseNumber",
                table: "Discounts",
                newName: "DiscountCount");

            migrationBuilder.RenameColumn(
                name: "Coupon",
                table: "Discounts",
                newName: "DiscountCode");

            migrationBuilder.AddColumn<DateTime>(
                name: "EndingDate",
                table: "Discounts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EndingDate",
                table: "Discounts");

            migrationBuilder.RenameColumn(
                name: "DiscountCount",
                table: "Discounts",
                newName: "UseNumber");

            migrationBuilder.RenameColumn(
                name: "DiscountCode",
                table: "Discounts",
                newName: "Coupon");
        }
    }
}

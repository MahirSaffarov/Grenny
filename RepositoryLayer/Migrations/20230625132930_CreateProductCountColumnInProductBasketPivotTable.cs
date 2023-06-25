using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateProductCountColumnInProductBasketPivotTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "ProductBaskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductCount",
                table: "Baskets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7898));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7964));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7969));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7917));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(7923));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8055));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8079));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8133));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8140));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8141));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8143));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8144));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8148));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8151));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8153));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 25, 17, 29, 29, 691, DateTimeKind.Local).AddTicks(8180));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "ProductBaskets");

            migrationBuilder.DropColumn(
                name: "ProductCount",
                table: "Baskets");

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8333));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8411));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8412));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8438));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8439));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8444));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8456));
        }
    }
}

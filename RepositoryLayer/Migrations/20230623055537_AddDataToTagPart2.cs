using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class AddDataToTagPart2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 6, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8441), "Crunchy", false },
                    { 7, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8441), "Savory", false },
                    { 8, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8442), "Gourmet", false },
                    { 9, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8442), "Satisfying", false },
                    { 10, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8443), "Delicious", false },
                    { 11, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8444), "Fresh", false },
                    { 12, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8444), "Juicy", false },
                    { 13, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8445), "SpiceUp", false },
                    { 14, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8445), "Tasty", false },
                    { 15, new DateTime(2023, 6, 23, 9, 55, 36, 484, DateTimeKind.Local).AddTicks(8446), "Zesty", false }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6435));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6562));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6631));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6633));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6675));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6676));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6686));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6694));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6706));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6716));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class AddDataToTagsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 3, new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6706), "Vegan", false },
                    { 4, new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6707), "Healthy", false },
                    { 5, new DateTime(2023, 6, 23, 8, 41, 0, 363, DateTimeKind.Local).AddTicks(6707), "Seafood", false }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8435));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8618));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8685));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8688));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8710));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8719));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8729));
        }
    }
}

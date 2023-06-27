using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateIsBlockColumnInAppUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBlock",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8368));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8489));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8551));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8626));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8651));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8681));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBlock",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(791));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(878));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(879));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(882));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(958));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(966));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(969));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(973));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(975));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(977));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2023, 6, 27, 2, 7, 49, 703, DateTimeKind.Local).AddTicks(991));
        }
    }
}

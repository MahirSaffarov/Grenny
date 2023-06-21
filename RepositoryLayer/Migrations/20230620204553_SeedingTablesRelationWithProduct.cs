using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class SeedingTablesRelationWithProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProductCount",
                table: "Products",
                newName: "StockCount");

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4168), false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4180), false }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4286), "01.jpg", "Vegan Lover", false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4287), "03.jpg", "Vegan Lover", false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4296), "01.jpg", "Vegetables", false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4297), "02.jpg", "Foods", false }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreateDate", "Name", "Percent", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4305), "Black Friday", (byte)50, false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4306), "No Discount", (byte)0, false }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "RatingCount", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4350), (byte)1, false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4351), (byte)2, false },
                    { 3, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4351), (byte)3, false },
                    { 4, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4352), (byte)4, false },
                    { 5, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4353), (byte)5, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4385), "Organic", false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4386), "Fruits", false }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4518), false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4519), false }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4377), "Cucumber", false },
                    { 2, 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4378), "Eggplant", false }
                });

            migrationBuilder.InsertData(
                table: "UserBaskets",
                columns: new[] { "Id", "AppUserId", "BasketId" },
                values: new object[,]
                {
                    { 1, "63da8847-87d5-4263-8977-2a15314c3cda", 1 },
                    { 2, "e674e9e0-4b03-45ba-b0ee-1634052fd308", 2 }
                });

            migrationBuilder.InsertData(
                table: "UserWishlists",
                columns: new[] { "Id", "AppUserId", "WishlistId" },
                values: new object[,]
                {
                    { 1, "63da8847-87d5-4263-8977-2a15314c3cda", 1 },
                    { 2, "e674e9e0-4b03-45ba-b0ee-1634052fd308", 2 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId", "WishlistId" },
                values: new object[] { 1, 1, 1, 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4314), "Cucumbers are commonly mistaken for vegetables. But in fact they are fruits, specifically berries. The long, green berries of the cucumber plant are what you usually find in your salads and sandwiches. They are made up of over 90% water, making them excellent for staying hydrated.", 1, "Cucumber", 50m, 1, 12345, 80, false, 100, 1, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BasketId", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId", "WishlistId" },
                values: new object[] { 2, 2, 2, 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4318), "The standard eggplant is an oval or pear-shaped, glossy, purplish fruit 6 to 9 inches long. Japanese and oriental varieties tend to be elongated and slender with a thinner, more delicate skin. Ornamental varieties are edible and tend to produce small, white-skinned, oval-shaped fruit.", 2, "Eggplant", 100m, 2, 54321, 180, false, 200, 2, 2 });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreateDate", "Image", "IsMain", "ProductId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4329), "01.jpg", true, 1, false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4330), "02.jpg", false, 1, false },
                    { 3, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4331), "03.jpg", true, 2, false },
                    { 4, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4331), "04.jpg", false, 2, false }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "Id", "ProductId", "TagId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreateDate", "Describe", "ProductId", "RatingId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4363), "Very tasty, it is the best cucumber i have ever eaten.", 1, 1, false },
                    { 2, new DateTime(2023, 6, 21, 0, 45, 53, 237, DateTimeKind.Local).AddTicks(4365), "It is a fresh vegetables. I liked it.", 2, 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserBaskets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserWishlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserWishlists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Discounts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SubCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.RenameColumn(
                name: "StockCount",
                table: "Products",
                newName: "ProductCount");
        }
    }
}

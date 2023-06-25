using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class DataofTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "AppUserId", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8435), false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8447), false }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8589), "01.jpg", "Vegan Lover", false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8591), "03.jpg", "Organic Foody", false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8600), "01.jpg", "Vegetables", false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8601), "02.jpg", "Foods", false }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreateDate", "Name", "Percent", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8609), "Black Friday", (byte)50, false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8610), "No Discount", (byte)0, false }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "RatingCount", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8685), (byte)1, false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8686), (byte)2, false },
                    { 3, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8687), (byte)3, false },
                    { 4, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8687), (byte)4, false },
                    { 5, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8688), (byte)5, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8718), "Organic", false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8719), "Fruits", false }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "AppUserId", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8728), false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8729), false }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "SoftDelete" },
                values: new object[] { 1, 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8709), "Cucumber", false });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "SoftDelete" },
                values: new object[] { 2, 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8710), "Eggplant", false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId" },
                values: new object[] { 1, 1, 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8618), "Cucumbers are commonly mistaken for vegetables. But in fact they are fruits, specifically berries. The long, green berries of the cucumber plant are what you usually find in your salads and sandwiches. They are made up of over 90% water, making them excellent for staying hydrated.", 1, "Cucumber", 50m, 1, 12345, 80, false, 100, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId" },
                values: new object[] { 2, 2, 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8622), "The standard eggplant is an oval or pear-shaped, glossy, purplish fruit 6 to 9 inches long. Japanese and oriental varieties tend to be elongated and slender with a thinner, more delicate skin. Ornamental varieties are edible and tend to produce small, white-skinned, oval-shaped fruit.", 2, "Eggplant", 100m, 2, 54321, 180, false, 200, 2 });

            migrationBuilder.InsertData(
                table: "ProductBaskets",
                columns: new[] { "Id", "BasketId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreateDate", "Image", "IsMain", "ProductId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8643), "01.jpg", true, 1, false },
                    { 2, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8644), "02.jpg", false, 1, false },
                    { 3, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8645), "03.jpg", true, 2, false },
                    { 4, new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8646), "04.jpg", false, 2, false }
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
                table: "ProductWishlists",
                columns: new[] { "Id", "ProductId", "WishlistId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "AppUserId", "CreateDate", "Describe", "ProductId", "RatingId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8699), "Very tasty, it is the best cucumber i have ever eaten.", 1, 1, false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", new DateTime(2023, 6, 21, 21, 49, 3, 442, DateTimeKind.Local).AddTicks(8701), "It is a fresh vegetables. I liked it.", 2, 2, false }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductBaskets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductBaskets",
                keyColumn: "Id",
                keyValue: 2);

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
                table: "ProductWishlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductWishlists",
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
                table: "Baskets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Baskets",
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
                table: "Wishlists",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Wishlists",
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
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

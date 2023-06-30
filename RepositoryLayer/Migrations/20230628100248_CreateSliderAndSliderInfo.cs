using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RepositoryLayer.Migrations
{
    public partial class CreateSliderAndSliderInfo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SliderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderInfos");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.InsertData(
                table: "Baskets",
                columns: new[] { "Id", "AppUserId", "Count", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", 0, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8354), false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", 0, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8368), false }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8488), "01.jpg", "Vegan Lover", false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8489), "03.jpg", "Organic Foody", false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8497), "01.jpg", "Vegetables", false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8498), "02.jpg", "Foods", false }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreateDate", "Name", "Percent", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8509), "Black Friday", (byte)50, false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8510), "No Discount", (byte)0, false }
                });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "Id", "CreateDate", "RatingCount", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8592), (byte)1, false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8626), (byte)2, false },
                    { 3, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8627), (byte)3, false },
                    { 4, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8628), (byte)4, false },
                    { 5, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8628), (byte)5, false }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8659), "Organic", false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8660), "Fruits", false },
                    { 3, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8661), "Vegan", false },
                    { 4, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8661), "Healthy", false },
                    { 5, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8662), "Seafood", false },
                    { 6, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8662), "Crunchy", false },
                    { 7, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8663), "Savory", false },
                    { 8, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8664), "Gourmet", false },
                    { 9, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8664), "Satisfying", false },
                    { 10, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8665), "Delicious", false },
                    { 11, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8665), "Fresh", false },
                    { 12, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8666), "Juicy", false },
                    { 13, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8666), "SpiceUp", false },
                    { 14, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8668), "Tasty", false },
                    { 15, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8668), "Zesty", false }
                });

            migrationBuilder.InsertData(
                table: "Wishlists",
                columns: new[] { "Id", "AppUserId", "CreateDate", "SoftDelete" },
                values: new object[,]
                {
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8680), false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8681), false }
                });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "SoftDelete" },
                values: new object[] { 1, 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8651), "Cucumber", false });

            migrationBuilder.InsertData(
                table: "SubCategories",
                columns: new[] { "Id", "CategoryId", "CreateDate", "Name", "SoftDelete" },
                values: new object[] { 2, 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8652), "Eggplant", false });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId" },
                values: new object[] { 1, 1, 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8517), "Cucumbers are commonly mistaken for vegetables. But in fact they are fruits, specifically berries. The long, green berries of the cucumber plant are what you usually find in your salads and sandwiches. They are made up of over 90% water, making them excellent for staying hydrated.", 1, "Cucumber", 50m, 1, 12345, 80, false, 100, 1 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "BrandId", "CategoryId", "CreateDate", "Description", "DiscountId", "Name", "Price", "RatingId", "SKUCode", "SalesCount", "SoftDelete", "StockCount", "SubCategoryId" },
                values: new object[] { 2, 2, 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8521), "The standard eggplant is an oval or pear-shaped, glossy, purplish fruit 6 to 9 inches long. Japanese and oriental varieties tend to be elongated and slender with a thinner, more delicate skin. Ornamental varieties are edible and tend to produce small, white-skinned, oval-shaped fruit.", 2, "Eggplant", 100m, 2, 54321, 180, false, 200, 2 });

            migrationBuilder.InsertData(
                table: "ProductBaskets",
                columns: new[] { "Id", "BasketId", "ProductCount", "ProductId" },
                values: new object[,]
                {
                    { 1, 1, 0, 1 },
                    { 2, 2, 0, 2 }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreateDate", "Image", "IsMain", "ProductId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8548), "01.jpg", true, 1, false },
                    { 2, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8549), "02.jpg", false, 1, false },
                    { 3, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8550), "03.jpg", true, 2, false },
                    { 4, new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8551), "04.jpg", false, 2, false }
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
                    { 1, "b59d27ed-5ac4-4cbc-819e-c36b80e2d334", new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8640), "Very tasty, it is the best cucumber i have ever eaten.", 1, 1, false },
                    { 2, "f565482b-e971-4580-8493-e5c5ba0479c9", new DateTime(2023, 6, 28, 0, 21, 2, 511, DateTimeKind.Local).AddTicks(8641), "It is a fresh vegetables. I liked it.", 2, 2, false }
                });
        }
    }
}

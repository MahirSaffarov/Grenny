using DomainLayer.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

            public DbSet<Basket> Baskets { get; set; }
            public DbSet<Brand> Brands { get; set; }
            public DbSet<Category> Categories { get; set; }
            public DbSet<Discount> Discounts { get; set; }
            public DbSet<Product> Products { get; set; }
            public DbSet<ProductImage> ProductImages { get; set; }
            public DbSet<ProductTag> ProductTags { get; set; }
            public DbSet<Rating> Ratings { get; set; }
            public DbSet<Review> Reviews { get; set; }
            public DbSet<Setting> Settings { get; set; }
            public DbSet<SubCategory> SubCategories { get; set; }
            public DbSet<Tag> Tags { get; set; }
            public DbSet<UserBasket> UserBaskets { get; set; }
            public DbSet<UserWishlist> UserWishlists { get; set; }
            public DbSet<Wishlist> Wishlists { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);


                modelBuilder.Entity<SubCategory>()
                .HasMany(e => e.Products)
                .WithOne(e => e.SubCategory)
                .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<Rating>()
                .HasMany(e => e.Reviews)
                .WithOne(e => e.Rating)
                .OnDelete(DeleteBehavior.Restrict);

                modelBuilder.Entity<Basket>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Discount>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Rating>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Review>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<SubCategory>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Tag>().HasQueryFilter(m => !m.SoftDelete);
                modelBuilder.Entity<Wishlist>().HasQueryFilter(m => !m.SoftDelete);

                modelBuilder.Entity<Basket>().HasData(
                 new Basket
                 {
                     Id = 1
                 },
                 new Basket
                 {
                     Id = 2
                 }
                 );

                modelBuilder.Entity<Brand>().HasData(
                    new Brand
                    {
                        Id = 1,
                        Name = "Vegan Lover",
                        Image = "01.jpg"
                    },
                    new Brand
                    {
                        Id = 2,
                        Name = "Vegan Lover",
                        Image = "03.jpg"
                    }
                    );

                modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Vegetables",
                        Image = "01.jpg"
                    },
                    new Category
                    {
                        Id = 2,
                        Name = "Foods",
                        Image = "02.jpg"
                    }
                    );

                modelBuilder.Entity<Discount>().HasData(
                   new Discount
                   {
                       Id = 1,
                       Name = "Black Friday",
                       Percent = 50
                   },
                   new Discount
                   {
                       Id = 2,
                       Name = "No Discount",
                       Percent = 0
                   }
                   );

                modelBuilder.Entity<Product>().HasData(
                   new Product
                   {
                       Id = 1,
                       Name = "Cucumber",
                       BasketId = 1,
                       BrandId = 1,
                       CategoryId = 1,
                       Description = "Cucumbers are commonly mistaken for vegetables. But in fact they are fruits, specifically berries. The long, green berries of the cucumber plant are what you usually find in your salads and sandwiches. They are made up of over 90% water, making them excellent for staying hydrated.",
                       DiscountId = 1,
                       Price = 50,
                       RatingId = 1,
                       StockCount = 100,
                       SalesCount = 80,
                       SKUCode = 12345,
                       SubCategoryId = 1,
                       WishlistId = 1
                   },
                   new Product
                   {
                       Id = 2,
                       Name = "Eggplant",
                       BasketId = 2,
                       BrandId = 2,
                       CategoryId = 2,
                       Description = "The standard eggplant is an oval or pear-shaped, glossy, purplish fruit 6 to 9 inches long. Japanese and oriental varieties tend to be elongated and slender with a thinner, more delicate skin. Ornamental varieties are edible and tend to produce small, white-skinned, oval-shaped fruit.",
                       DiscountId = 2,
                       Price = 100,
                       RatingId = 2,
                       StockCount = 200,
                       SalesCount = 180,
                       SKUCode = 54321,
                       SubCategoryId = 2,
                       WishlistId = 2
                   }
                   );

                modelBuilder.Entity<ProductImage>().HasData(
                   new ProductImage
                   {
                       Id = 1,
                       Image = "01.jpg",
                       ProductId = 1,
                       IsMain = true
                   },
                   new ProductImage
                   {
                       Id = 2,
                       Image = "02.jpg",
                       ProductId= 1,
                       IsMain = false
                   },
                   new ProductImage
                   {
                       Id = 3,
                       Image = "03.jpg",
                       ProductId = 2,
                       IsMain = true
                   },
                   new ProductImage
                   {
                       Id = 4,
                       Image = "04.jpg",
                       ProductId = 2,
                       IsMain = false
                   }
                   );

                modelBuilder.Entity<ProductTag>().HasData(
                   new ProductTag
                   {
                       Id = 1,
                       ProductId = 1,
                       TagId = 1
                   },
                   new ProductTag
                   {
                       Id = 2,
                       ProductId = 2,
                       TagId= 2
                   }
                   );

                modelBuilder.Entity<Rating>().HasData(
                   new Rating
                   {
                       Id = 1,
                       RatingCount = 1
                   },
                   new Rating
                   {
                       Id = 2,
                       RatingCount = 2
                   },
                   new Rating
                   {
                       Id = 3,
                       RatingCount = 3
                   },
                   new Rating
                   {
                       Id = 4,
                       RatingCount = 4
                   },
                   new Rating
                   {
                       Id = 5,
                       RatingCount = 5
                   }
                   );

                modelBuilder.Entity<Review>().HasData(
                   new Review
                   {
                       Id = 1,
                       ProductId = 1,
                       RatingId = 1,
                       Describe = "Very tasty, it is the best cucumber i have ever eaten."

                   },
                   new Review
                   {
                       Id = 2,
                       ProductId = 2,
                       RatingId = 2,
                       Describe = "It is a fresh vegetables. I liked it."
                   }
                   );

                modelBuilder.Entity<SubCategory>().HasData(
                    new SubCategory
                    {
                        Id= 1,
                        CategoryId = 1,
                        Name = "Cucumber"
                    },
                    new SubCategory
                    {
                        Id = 2,
                        CategoryId = 2,
                        Name = "Eggplant"
                    }
                    );

                modelBuilder.Entity<Tag>().HasData(
                    new Tag
                    {
                        Id = 1,
                        Name = "Organic"
                    },
                    new Tag
                    {
                        Id = 2,
                        Name = "Fruits"
                    }
                    );

                modelBuilder.Entity<UserBasket>().HasData(
                    new UserBasket
                    {
                        Id = 1,
                        AppUserId = "63da8847-87d5-4263-8977-2a15314c3cda",
                        BasketId = 1,
                    },
                    new UserBasket
                    {
                        Id = 2,
                        AppUserId = "e674e9e0-4b03-45ba-b0ee-1634052fd308",
                        BasketId = 2,
                    }
                    );

                modelBuilder.Entity<UserWishlist>().HasData(
                    new UserWishlist
                    {
                        Id = 1,
                        AppUserId = "63da8847-87d5-4263-8977-2a15314c3cda",
                        WishlistId = 1,
                    },
                    new UserWishlist
                    {
                        Id = 2,
                        AppUserId = "e674e9e0-4b03-45ba-b0ee-1634052fd308",
                        WishlistId = 2,
                    }
                    );
                modelBuilder.Entity<Wishlist>().HasData(
                    new Wishlist
                    {
                        Id = 1
                    },
                    new Wishlist
                    {
                        Id = 2
                    }
                    );
            }
        }
    }
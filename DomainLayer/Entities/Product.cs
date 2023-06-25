
using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int SKUCode { get; set; }
        public int SalesCount { get; set; }
        public int StockCount { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        [ForeignKey("SubCategory")]
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int RatingId { get; set; }
        public Rating Rating { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public ICollection<ProductTag> ProductTags { get; set; }
        public ICollection<ProductWishlist> ProductWishlists { get; set; }
        public ICollection<ProductBasket> ProductBaskets { get; set; }

    }
}

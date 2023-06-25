using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.ProductVM
{
    public class ProductDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string Discount { get; set; }
        public IEnumerable<ProductImage> Images { get; set; }
        public string Price { get; set; }
        public int StockCount { get; set; }
        public string SubCategory { get; set; }
        public IEnumerable<ProductTag> ProductTags { get; set; }
        public byte Rating { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public int SalesCount { get; set; }
        public int SKUCode { get; set; }
    }
}

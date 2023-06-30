using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.Product
{
    public class ProductVM
    {
        public int Id { get; set; }
        public int SkuCode { get; set; }
        public string Name { get; set; }
        public byte Rating { get; set; }
        public decimal Price { get; set; }
        public int ReviewCount { get; set; }
        public Discount Discounts { get; set; }
        public Rating Ratings { get; set; }
        public string Desc { get; set; }
        public int SaleCount { get; set; }
        public List<string> Images { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public IEnumerable<Tag> Tags { get; set; }
    }
}

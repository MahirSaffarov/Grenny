using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.ProductVM
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SKUCode { get; set; }
        public string Brand { get; set; }
        public decimal Rating { get; set; }
        public string Reviews { get; set; }
        public int ReviewCount { get; set; }
        public string ReviewCreateDate { get; set; }
        public decimal Price { get; set; }
        public byte Discount { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public IEnumerable<ProductImage> Images { get; set; }
        public string UserFullName { get; set; }
    }
}

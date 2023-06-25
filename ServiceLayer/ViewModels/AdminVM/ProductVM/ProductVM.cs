using DomainLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

namespace ServiceLayer.ViewModels.AdminVM.ProductVM
{
    public class ProductVM
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public string Name { get; set; }
        public string Discount { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int StockCount { get; set; }
    }
}

using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.ProductVM
{
    public class AddVM
    {
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public int DiscountId { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public int StockCount { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public List<IFormFile> Images { get; set; }
        public List<CheckBoxVM> CheckBoxes { get; set; }
    }
}

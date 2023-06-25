using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.ViewModels.AdminVM.ProductVM
{
    public class EditVM
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
        public ICollection<ProductImage>? Images { get; set; }
        public List<IFormFile>? NewImage { get; set; }
        public List<CheckBoxVM> CheckBoxes { get; set; }
    }
}

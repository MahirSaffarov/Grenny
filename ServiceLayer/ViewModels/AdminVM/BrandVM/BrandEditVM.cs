using DomainLayer.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.BrandVM
{
    public class BrandEditVM
    {
        [Required]
        public string Name { get; set; }
        public string? Images { get; set; }
        public IFormFile? NewImage { get; set; }
    }
}

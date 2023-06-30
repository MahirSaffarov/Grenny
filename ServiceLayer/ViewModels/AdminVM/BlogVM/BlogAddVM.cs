using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.BlogVM
{
    public class BlogAddVM
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Text { get; set; }
        public int TeamId { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}

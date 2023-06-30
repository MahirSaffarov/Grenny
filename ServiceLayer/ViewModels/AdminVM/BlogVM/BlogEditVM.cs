using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.BlogVM
{
    public class BlogEditVM
    {
        public int TeamId { get; set; }
        public string? Images { get; set; }
        public IFormFile? NewImage { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public string Title { get; set; }
    }
}

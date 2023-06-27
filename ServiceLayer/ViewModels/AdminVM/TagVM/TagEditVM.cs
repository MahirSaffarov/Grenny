using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.TagVM
{
    public class TagEditVM
    {
        [Required]
        public string Name { get; set; }
    }
}

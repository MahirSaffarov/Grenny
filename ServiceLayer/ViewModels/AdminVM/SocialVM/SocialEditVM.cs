using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.SocialVM
{
    public class SocialEditVM
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Icon { get; set; }
    }
}

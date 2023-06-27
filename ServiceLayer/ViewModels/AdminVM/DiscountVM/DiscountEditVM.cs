using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.DiscountVM
{
    public class DiscountEditVM
    {
        [Required]
        public string Name { get; set; }
        public byte Percent { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.RatingVM
{
    public class RatingAddVM
    {
        [Required]
        public byte RatingCount { get; set; }
    }
}

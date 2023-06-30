using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.AdversitmentVM
{
    public class AdversitmentAddVM
    {
        [Required]
        public List<IFormFile> Images { get; set; }
    }
}

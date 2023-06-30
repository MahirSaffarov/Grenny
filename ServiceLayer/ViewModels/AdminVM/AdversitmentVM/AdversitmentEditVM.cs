using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.AdversitmentVM
{
    public class AdversitmentEditVM
    {
        public string Image { get; set; }
        public IFormFile NewImage { get; set; }
    }
}

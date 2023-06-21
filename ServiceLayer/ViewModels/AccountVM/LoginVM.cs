using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AccountVM
{
    public class LoginVM
    {
        [Required]
        public string EmailOrUsername { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

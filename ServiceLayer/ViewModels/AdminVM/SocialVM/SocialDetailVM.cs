using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.SocialVM
{
    public class SocialDetailVM
    {
        public string Name { get; set; }
        public string Icon { get; set; }
        public string CreateDate { get; set; }
    }
}

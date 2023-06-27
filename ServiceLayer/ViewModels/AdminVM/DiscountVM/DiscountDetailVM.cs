using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.AdminVM.DiscountVM
{
    public class DiscountDetailVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Percent { get; set; }
        public string CreateDate { get; set; }
    }
}

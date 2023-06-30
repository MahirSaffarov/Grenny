using ServiceLayer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.BrandPageVM
{
    public class BrandPageVM
    {
        public string Name { get; set; }
        public string Image { get; set; }
        public int ProductCount { get; set; }
        public Paginate<BrandPageVM> Paginate { get; set; }
    }
}

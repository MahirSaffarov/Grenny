using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Subcategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.HeaderPageVM
{
    public class HeaderPageVM
    {
        public IEnumerable<CategoryVM> CategoryVM { get; set; }
        public IEnumerable<SubcategoryVM> SubcategoryVM { get; set; }
        public LayoutVM Data { get; set; }
    }
}

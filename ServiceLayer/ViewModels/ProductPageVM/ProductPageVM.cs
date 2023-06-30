using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.Social;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.ProductPageVM
{
    public class ProductPageVM
    {
        public IEnumerable<SocialVM> SocialVM { get; set; }
        public ProductVM ProductVM { get; set; }
    }
}

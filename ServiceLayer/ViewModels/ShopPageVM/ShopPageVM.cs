using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.Brand;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.ShopPageVM
{
    public class ShopPageVM
    {
        public IEnumerable<ProductVM> ProductVM { get; set; }
        public IEnumerable<AdversitmentVM> AdversitmentVM { get; set; }
        public IEnumerable<RatingVM> RatingVM { get; set; }
        public IEnumerable<TagVM> TagVM { get; set; }
        public IEnumerable<BrandVM> BrandVM { get; set; }
        public IEnumerable<CategoryVM> CategoryVM { get; set; }
    }
}

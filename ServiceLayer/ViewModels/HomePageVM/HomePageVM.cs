
using DomainLayer.Entities;
using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.Brand;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Product;
using ServiceLayer.ViewModels.Slider;
using ServiceLayer.ViewModels.SliderInfo;

namespace ServiceLayer.ViewModels.HomePageVM
{
    public class HomePageVM
    {
        public IEnumerable<ProductVM> ProductVM { get; set; }
        public IEnumerable<SliderVM> SliderVM { get; set; }
        public IEnumerable<SliderInfoVM> SliderInfoVM { get; set; }
        public IEnumerable<CategoryVM> CategoryVM { get; set; }
        public IEnumerable<AdversitmentVM> AdversitmentVM { get; set; }
        public IEnumerable<BrandVM> BrandVM { get; set; }
        public IEnumerable<BlogVM> BlogVM { get; set; }
    }
}

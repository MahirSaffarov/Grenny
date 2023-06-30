using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Social;
using ServiceLayer.ViewModels.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.ViewModels.BlogPageVM
{
    public class BlogPageVM
    {
        public IEnumerable<AdversitmentVM> AdversitmentVM { get; set; }
        public IEnumerable<TagVM> TagVM { get; set; }
        public IEnumerable<SocialVM> SocialVM { get; set; }
        public IEnumerable<CategoryVM> CategoryVM { get; set; }
        public IEnumerable<BlogVM> BlogVM { get; set; }
    }
}

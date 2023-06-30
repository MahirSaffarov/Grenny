using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AboutPageVM;
using ServiceLayer.ViewModels.Adversitment;
using ServiceLayer.ViewModels.Blog;
using ServiceLayer.ViewModels.BlogPageVM;
using ServiceLayer.ViewModels.Category;
using ServiceLayer.ViewModels.Social;
using ServiceLayer.ViewModels.Tag;
using ServiceLayer.ViewModels.Team;

namespace Grenny.Controllers
{
    public class BlogController : Controller
    {
        private readonly IAdversitmentService _adversitmentService;
        private readonly IBlogService _blogService;
        private readonly ICategoryService _categoryService;
        private readonly ITagService _tagService;
        private readonly ISocialService _socialService;
        public BlogController(
                              IAdversitmentService adversitmentService, 
                              IBlogService blogService, 
                              ICategoryService categoryService, 
                              ITagService tagService, 
                              ISocialService socialService)
        {
            _adversitmentService = adversitmentService;
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
            _socialService = socialService;
        }

        public async Task<IActionResult> Index()
        {
            var blogPageVM = new BlogPageVM
            {
                AdversitmentVM = await GetAdversitmentVMs(),
                CategoryVM = await GetCategoryVMs(),
                BlogVM = await GetBlogVMs(),
                SocialVM = await GetSocialVMs(),
                TagVM = await GetTagVMs(),
            };

            return View(blogPageVM);
        }
        private async Task<IEnumerable<SocialVM>> GetSocialVMs()
        {
            var socials = await _socialService.GetAllAsync();

            var socialVMs = new List<SocialVM>();

            var socialViewModels = socials.Select(member => new SocialVM
            {
                Name = member.Name,
                Icon = member.Icon
            });

            return socialViewModels;
        }
        private async Task<IEnumerable<TagVM>> GetTagVMs()
        {
            var tags = await _tagService.GetAllAsync();

            var tagVMs = new List<TagVM>();

            var tagViewModels = tags.Select(member => new TagVM
            {
                Name = member.Name
            });

            return tagViewModels;
        }
        private async Task<IEnumerable<AdversitmentVM>> GetAdversitmentVMs()
        {
            var ads = await _adversitmentService.GetAllAsync();

            var adsVM = new List<AdversitmentVM>();

            var adsViewModels = ads.Select(member => new AdversitmentVM
            {
                Image = member.Image
            });

            return adsViewModels;
        }
        private async Task<IEnumerable<BlogVM>> GetBlogVMs()
        {
            var blogs = await _blogService.GetAllWithIncludes();

            var blogVM = new List<BlogVM>();

            var blogViewModels = blogs.Select(member => new BlogVM
            {
                Team = member.Team.Name,
                Text = member.Text,
                Title = member.Title,
                CreateDate = member.CreateDate.ToString("dddd/MMMM/yyyyy"),
                Image = member.Image
            });

            return blogViewModels;
        }
        private async Task<IEnumerable<CategoryVM>> GetCategoryVMs()
        {
            var categories = await _categoryService.GetAllWithIncludes();

            var category = new List<CategoryVM>();

            var categoryViewModels = categories.Select(member => new CategoryVM
            {
                Name = member.Name,
                ProductCount = member.Products.Count,
            });

            return categoryViewModels.Take(4);
        }
    }
}

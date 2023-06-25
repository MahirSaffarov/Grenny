using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using RepositoryLayer.Repositories;
using ServiceLayer.Services.Implementations;
using Grenny.Helpers;

namespace Grenny.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Admin")]
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IDiscountService _discountService;
        private readonly ICategoryService _categoryService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IBrandService _brandService;
        private readonly ITagService _tagService;
        private readonly IProductTagService _productTagService;

        public ProductController(IProductService productService,
                                 IDiscountService discountService,
                                 ICategoryService categoryService,
                                 ISubCategoryService subCategoryService,
                                 IBrandService brandService,
                                 ITagService tagService,
                                 IProductTagService productTagService)
        {
            _productService = productService;
            _discountService = discountService;
            _categoryService = categoryService;
            _subCategoryService = subCategoryService;
            _brandService = brandService;
            _tagService = tagService;
            _productTagService = productTagService;
        }
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllWithIncludes();

            List<ProductVM> productsVM = new();

            foreach (var product in products)
            {
                productsVM.Add(new ProductVM
                {
                    Brand = product.Brand.Name,
                    Category = product.Category.Name,
                    Discount = product.Discount.Name,
                    Name = product.Name,
                    Id = product.Id,
                    Image = product.Images.FirstOrDefault().Image,
                    Price = product.Price,
                    StockCount = product.StockCount,    
                    SubCategory = product.SubCategory.Name
                });
            }
            return View(productsVM);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        { 
            var product = await _productService.GetByIdWithAllIncludesAsync(id);

            ProductDetailVM details = new()
            {
                Name = product.Name,
                Brand = product.Brand.Name,
                Category = product.Category.Name,
                Description = product.Description,
                Discount = product.Discount.Name,
                Images = product.Images,
                Price = product.Price.ToString("0.#####"),
                StockCount = product.StockCount,
                SubCategory = product.SubCategory.Name,
                ProductTags = product.ProductTags,
                Rating = product.Rating.RatingCount,
                Reviews = product.Reviews,
                SalesCount = product.SalesCount,
                SKUCode = product.SKUCode,
            };
            return View(details);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {

            await GetAllSelectOptions();

            var tags = await _tagService.GetAllAsync();
            List<CheckBoxVM> checkBoxVMs = new();

             foreach (var tag in tags)
            {
                checkBoxVMs.Add(new CheckBoxVM { Id = tag.Id, LabelName = tag.Name, IsChecked = false });
            }

            AddVM model = new()
            {
                CheckBoxes = checkBoxVMs
            };

            return View(model);
        } 

        [HttpPost]
        public async Task<IActionResult> AddAsync(AddVM request)
        {
            await GetAllSelectOptions();
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            foreach (var item in request.Images)
            {
                if (!item.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Image", "Please select only image file.");
                    return View(request);
                }

                if (item.CheckFileSize(2000))
                {
                    ModelState.AddModelError("Image", "Please select under 200KB image");
                    return View(request);
                }
            }

            var tags = await _tagService.GetAllAsync();

            await _productService.AddAsync(request);

            return RedirectToAction(nameof(Index)); 
        }   
        public async Task<JsonResult> GetSubCategoryByCategoryId(int categoryId)
        {
            var subCatog = await _subCategoryService.GetAllAsync();
            
            return Json(subCatog.Where(m => m.CategoryId == categoryId).ToList());
        }
        private async Task GetAllSelectOptions()
        {
            ViewBag.categories = await GetCategories();
            ViewBag.subcategories = await GetSubCategories();
            ViewBag.discounts = await GetDiscounts();
            ViewBag.brands = await GetBrands();
        }
        private async Task<SelectList> GetCategories()
        {
            IEnumerable<Category> categories = await _categoryService.GetAllAsync();
            return new SelectList(categories, "Id", "Name");
        }
        private async Task<SelectList> GetSubCategories()
        {
            IEnumerable<SubCategory> subCategories = await _subCategoryService.GetAllAsync();
            return new SelectList(subCategories, "Id", "Name");
        }
        private async Task<SelectList> GetDiscounts()
        {
            IEnumerable<Discount> discounts = await _discountService.GetAllAsync();
            return new SelectList(discounts, "Id", "Name");
        }
        private async Task<SelectList> GetBrands()
        {
            IEnumerable<Brand> brands = await _brandService.GetAllAsync();
            return new SelectList(brands, "Id", "Name");
        }
        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int? id)
        {
            if (id == null) return BadRequest();

            await _productService.DeleteAsync((int)id);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id is null) BadRequest();

            Product product = await _productService.GetByIdWithAllIncludesAsync((int)id);

            if (product == null) return NotFound();

            await GetAllSelectOptions();

            var tags = await _tagService.GetAllAsync();
            List<CheckBoxVM> checkBoxVMs = new();

            foreach (var tag in tags)
            {
                bool isChecked = tag.ProductTags?.Any(m => m.ProductId == product.Id) ?? false;
                checkBoxVMs.Add(new CheckBoxVM { Id = tag.Id, LabelName = tag.Name, IsChecked = isChecked });
            }
           
            EditVM model = new()
            {
                CategoryId = product.CategoryId,
                Name = product.Name,
                BrandId = product.BrandId,
                CheckBoxes = checkBoxVMs,
                Description = product.Description,
                DiscountId = product.DiscountId,
                Images = product.Images,
                Price = product.Price,
                StockCount = product.StockCount,
                SubCategoryId = product.SubCategoryId

            };
 
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(EditVM request, int? id)
        {
            if (id is null)
                return BadRequest();

            await GetAllSelectOptions();

            var product = await _productService.GetByIdWithAllIncludesAsync((int)id);

            if (product == null)
                return NotFound();

            if (!ModelState.IsValid)
            {
                request.Images = product.Images.ToList();
                return View(request);
            }

            if (request.NewImage != null)
            {
                foreach (var image in request.NewImage)
                {
                    if (!image.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("NewImage", "Please select only an image file.");
                        request.Images = product.Images.ToList();
                        return View(request);
                    }

                    if (image.CheckFileSize(20000))
                    {
                        ModelState.AddModelError("NewImage", "The image size must be a maximum of 200KB.");
                        request.Images = product.Images.ToList();
                        return View(request);
                    }
                }
            }

            await _productService.EditAsync((int)id, request);

            return RedirectToAction(nameof(Index));
        }



    }
}

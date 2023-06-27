using DomainLayer.Entities;
using Grenny.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Org.BouncyCastle.Asn1.Ocsp;
using RepositoryLayer.Repositories.Interfaces;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.AdminVM.ProductVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ServiceLayer.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IProductTagService _productTagService;
        private readonly IProductImageService _productImageService;
        private readonly IWebHostEnvironment _env;
        public ProductService(IProductRepository productRepository,
                              IWebHostEnvironment env,
                              IProductTagService productTagService,
                              IProductImageService productImageService)
        {
            _productRepository = productRepository;
            _env = env;
            _productTagService = productTagService;
            _productImageService = productImageService;
        }

        public async Task AddAsync(AddVM model)
        {
            List<ProductImage> images = new();

            foreach (var item in model.Images)
            {
                string fileName = Guid.NewGuid().ToString() + "_" + item.FileName;
                await item.SaveFileAsync(fileName, _env.WebRootPath, "images/product");

                images.Add(new ProductImage { Image = fileName });
            }

            images.FirstOrDefault().IsMain = true;


            Product product = new()
            {
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                BrandId = model.BrandId,
                RatingId = 5,
                CategoryId = model.CategoryId,
                SubCategoryId = model.SubCategoryId,
                DiscountId = model.DiscountId,
                Images = images,
                StockCount = model.StockCount,
                SKUCode = GenerateUniqueNumber()
            };

            await _productRepository.AddAsync(product);

            foreach (var item in model.CheckBoxes)
            {
                if (item.IsChecked)
                {
                    await _productTagService.AddTagToProductAsync(product, item.Id);
                }
            }

        }
        private int GenerateUniqueNumber()
        {
            Random random = new Random();
            int number = random.Next(1000000, 9999999);

            while (!IsUnique(number))
            {
                number = random.Next(1000000, 9999999);
            }

            return number;
        }
        private bool IsUnique(int number)
        {
            string numberString = number.ToString();
            char[] digits = numberString.ToCharArray();

            HashSet<char> uniqueDigits = new HashSet<char>();

            foreach (char digit in digits)
            {
                if (!uniqueDigits.Add(digit))
                {
                    return false;
                }
            }

            return true;
        }
        public async Task DeleteAsync(int id)
        {
            Func<IQueryable<Product>, IIncludableQueryable<Product, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.Images)
            };

            var product = await _productRepository.GetByIdWithAllIncludesAsync(id, includeFuncs);

            await _productRepository.DeleteAsync(product);

            foreach (var item in product.Images)
            {
                string directoryPath = Path.Combine(_env.WebRootPath, "images/product", item.Image);

                if (System.IO.File.Exists(directoryPath))
                {
                    System.IO.File.Delete(directoryPath);
                }
            }
        }

        public async Task<IEnumerable<Product>> GetAllWithIncludes()
        {
            Func<IQueryable<Product>, IIncludableQueryable<Product, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.ProductTags).ThenInclude(m=>m.Tag),
                entity => entity.Include(m=>m.SubCategory),
                entity => entity.Include(m=>m.Category),
                entity => entity.Include(m=>m.Discount),
                entity => entity.Include(m=>m.Brand),
                entity => entity.Include(m=>m.Rating),
                entity => entity.Include(m=>m.Images),
                entity => entity.Include(m=>m.Reviews),
                entity => entity.Include(m=>m.Reviews).ThenInclude(m=>m.AppUser)
            };

            return await _productRepository.GetAllWithIncludesAsync(includeFuncs);
        }

        public async Task<Product> GetByIdWithAllIncludesAsync(int id)
        {
            Func<IQueryable<Product>, IIncludableQueryable<Product, object>>[] includeFuncs =
            {
                entity => entity.Include(m=>m.ProductTags).ThenInclude(m=>m.Tag),
                entity => entity.Include(m=>m.SubCategory),
                entity => entity.Include(m=>m.Category),
                entity => entity.Include(m=>m.Discount),
                entity => entity.Include(m=>m.Brand),
                entity => entity.Include(m=>m.Rating),
                entity => entity.Include(m=>m.Images),
                entity => entity.Include(m=>m.Reviews),
                entity => entity.Include(m=>m.Reviews).ThenInclude(m=>m.AppUser)
            };

            return await _productRepository.GetByIdWithAllIncludesAsync(id, includeFuncs);
        }

        public async Task EditAsync(int productId, EditVM model)
        {
            List<ProductImage> images = new List<ProductImage>();

            var product = await _productRepository.GetByIdAsync(productId);

            if (model.NewImage != null && model.NewImage.Any())
            {
                foreach (var item in model.NewImage)
                {
                    string fileName = Guid.NewGuid().ToString() + "_" + item.FileName;
                    await item.SaveFileAsync(fileName, _env.WebRootPath, "images/product");
                    images.Add(new ProductImage { Image = fileName, ProductId = productId });
                }
            }

            product.BrandId = model.BrandId;
            product.CategoryId = model.CategoryId;
            product.SubCategoryId = model.SubCategoryId;
            product.Name = model.Name;
            product.DiscountId = model.DiscountId;
            product.Price = model.Price;
            product.StockCount = model.StockCount;
            product.Description = model.Description;

            var currentTags = await _productTagService.GetTagsByProductIdAsync(product.Id);

            var updatedTagIds = model.CheckBoxes.Where(c => c.IsChecked).Select(c => c.Id);

            var tagsToRemove = currentTags.Where(t => !updatedTagIds.Contains(t.TagId));

            var tagsToAdd = updatedTagIds.Where(id => !currentTags.Any(t => t.TagId == id))
                                        .Select(id => new ProductTag { ProductId = product.Id, TagId = id });

            foreach (var tagToRemove in tagsToRemove)
            {
                await _productTagService.RemoveTagFromProductAsync(product, tagToRemove.TagId);
            }

            foreach (var tagToAdd in tagsToAdd)
            {
                await _productTagService.AddTagToProductAsync(product, tagToAdd.TagId);
            }

            await _productImageService.AddRangeAsync(images);
            await _productRepository.EditAsync(product);
        }


    }
}

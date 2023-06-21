
using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.HomeVM;
using System.Diagnostics;

namespace Grenny.Controllers
{
    public class HomeController : Controller
    { 
        private readonly IProductService _productService;
        public HomeController(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productService.GetAllAsync();

            HomeVM homeVM = new()
            {
                Products = products
            };

            return View(homeVM);
        }
    }
}
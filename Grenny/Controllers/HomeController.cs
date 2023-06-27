
using DomainLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Services.Interfaces;
using ServiceLayer.ViewModels.BasketVM;
using ServiceLayer.ViewModels.HomeVM;
using System.Diagnostics;
using System.Text.Json;

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
            IEnumerable<Product> products = await _productService.GetAllWithIncludes();
            
            HomeVM homeVM = new()
            {
                Products = products
            };

            return View(homeVM);
        }

    }
}
using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Services;
using ShoppingCenter.Web.Models;
using ShoppingCenter.Web.Services;

namespace ShoppingCenter.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _productService;

        public HomeController(ICategoryService productService)
        {
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var categories = await _productService.GetProductCategoriesAsync();
            return View(categories);
        }

        
    }
}

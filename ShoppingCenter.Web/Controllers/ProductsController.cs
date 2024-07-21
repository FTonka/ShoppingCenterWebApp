using Microsoft.AspNetCore.Mvc;
using ShoppingCenter.Web.Models;
using ShoppingCenter.Web.Services;

namespace ShoppingCenter.Web.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string point)
        {

            var products = await _productService.GetProductsAsync(point);

            return View(products.Products);
        }

        [HttpGet]
        public async Task<IActionResult> Details(string point, string barcode)
        {
            var details = await _productService.GetProductsAsync(point);

            IEnumerable<Product> response = details.Products;

            Product product = null;

            

            foreach(var item in response)
            {
                if(item.Meta.Barcode == barcode)
                {
                    product = item;
                    break;
                }
            }
            
            return View(product);
        }
    }
}

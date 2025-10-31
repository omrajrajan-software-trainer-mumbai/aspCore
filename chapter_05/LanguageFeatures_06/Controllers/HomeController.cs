using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeatures_06.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray = {new Product {Name = "Kayak", Price = 275M},new Product {Name = "Lifejacket", Price = 48.95M},new Product {Name = "Soccer ball", Price = 19.50M},new Product {Name = "Corner flag", Price = 34.95M}};
            decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
            return View("Index",new string[] { $"Array Total: {arrayTotal:C2}" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

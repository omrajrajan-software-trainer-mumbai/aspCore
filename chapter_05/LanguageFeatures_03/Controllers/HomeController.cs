using System.Diagnostics;
using System.Net.NetworkInformation;

namespace LanguageFeatures_03.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public ViewResult Index()
        {
            Product?[] products = Product.GetProducts();

            // Using the null - coalescing operator
            return View(new string[] { products[0]?.Name ?? "No Value" });

            // Using the null - forgiving operator
            // return View(new string[] { products[0]!.Name });

            // Disabling warnings
            // return View(new string[] { products[0].Name });
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

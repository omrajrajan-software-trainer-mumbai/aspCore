using System.Diagnostics;

namespace LanguageFeatures_04.Controllers
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
            {
                Dictionary<string, Product> products = new Dictionary<string, Product> {["Kayak"] = new Product { Name = "Kayak", Price = 275M },["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }};
                return View("Index", products.Keys);
            }
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

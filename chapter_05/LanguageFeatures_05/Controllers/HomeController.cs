using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LanguageFeatures_05.Controllers
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
            object[] data = new object[] { 275M, 29.95M,"apple", "orange", 100, 10 };
            decimal total = 0;
                for (int i = 0; i < data.Length; i++)
                {
                    switch (data[i])
                    {
                        case decimal decimalValue:
                            total += decimalValue;
                            break;
                        case int intValue when intValue > 50:
                            total += intValue;
                            break;
                    }
                }
            return View("Index", new string[] { $"Total: {total:C2}" });
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

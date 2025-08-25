// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures_01.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Dictionary<string, Product> products = new()
            {
                ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
                ["Lifejacket"] = new Product
                {
                    Name = "Lifejacket",
                    Price = 48.95M
                }
            };
            return View("Index", products.Keys);
        }
    }
}
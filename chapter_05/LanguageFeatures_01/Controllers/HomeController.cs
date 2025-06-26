// using Microsoft.AspNetCore.Mvc;
// using LanguageFeatures_01.Models;

namespace LanguageFeatures_01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            Product[] products = Product.GetProducts();
            return View(new string[] { products[0].Name });
        }
    }
}

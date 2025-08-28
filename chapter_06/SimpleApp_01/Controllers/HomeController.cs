using Microsoft.AspNetCore.Mvc;
using SimpleApp_01.Models;
namespace SimpleApp_01.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(Product.GetProducts());
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using SportsStore_01.Models;

namespace SportsStore_01.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public IActionResult Index() => View(repository.Products);
    }
}
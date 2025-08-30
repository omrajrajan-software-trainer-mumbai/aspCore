using Microsoft.AspNetCore.Mvc;
using SportsStore_01.Models;
using SportsStore_01.Models.ViewModels;

namespace SportsStore_01.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;

        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        public ViewResult Index(int productPage = 1) => View(new ProductsListViewModel
        {
            Products = repository.Products.OrderBy(p => p.ProductID).Skip((productPage - 1) * PageSize).Take(PageSize),
            PagingInfo = new PagingInfo
            {
                CurrentPage = productPage,
                ItemsPerPage = PageSize,
                TotalItems = repository.Products.Count()
            }
        });
    }   
}
namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index() =>
        View(Product.GetProducts().Select(p => p?.Name));
    }
}
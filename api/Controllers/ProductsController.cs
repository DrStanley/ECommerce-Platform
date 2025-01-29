using Microsoft.AspNetCore.Mvc;

namespace ECommercePlatform.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

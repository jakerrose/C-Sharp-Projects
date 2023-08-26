using Microsoft.AspNetCore.Mvc;

namespace CoreWebApplication1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

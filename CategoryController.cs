using Microsoft.AspNetCore.Mvc;

namespace Chrz_Library.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Chrz_Library.Controllers
{
    public class BooksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

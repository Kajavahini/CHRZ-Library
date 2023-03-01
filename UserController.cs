using Microsoft.AspNetCore.Mvc;

namespace Chrz_Library.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

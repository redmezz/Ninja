using Microsoft.AspNetCore.Mvc;

namespace Ninja.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

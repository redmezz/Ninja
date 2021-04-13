using Microsoft.AspNetCore.Mvc;


namespace Ninja.Controllers
{
  public class UserController : Controller
  {
    
    
    public IActionResult Index()
    {
      return View();
    }
  }
}

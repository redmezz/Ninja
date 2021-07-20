using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ninja.Controllers
{
    public class GetToKnowUsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

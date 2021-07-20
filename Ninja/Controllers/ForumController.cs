using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ninja.Data;
using Ninja.Models;
using System.Collections.Generic;

namespace Ninja.Controllers
{
    public class ForumController : Controller
    {
        private readonly ApplicationDbContext _db;
        public ForumController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {


            IEnumerable<Forum> forumList = _db.Forums;
            return View(forumList);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
    }
}

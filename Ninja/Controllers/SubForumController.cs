using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Ninja.Data;
using Ninja.Models;
using System.Collections.Generic;

namespace Ninja.Controllers
{
    public class SubforumController : Controller
    {
        private readonly ApplicationDbContext _db;
        public SubforumController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<SubForum> subForumList = _db.SubForums;
            return View(subForumList);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Ninja.Data;
using Ninja.Models;
using System.Collections.Generic;

namespace Ninja.Controllers
{
  public class ComputerController : Controller
  {
    private readonly ApplicationDbContext _db;
    public ComputerController(ApplicationDbContext db)
    {
      _db = db;
    }
    public IActionResult Index()
    {
      IEnumerable<Computer> forumList = _db.ComputerForum;
      return View(forumList);
    }

    // GET - Create
    public IActionResult Create()
    {
      return View();
    }

    // POST - Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Save(Computer obj)
    {
      if (ModelState.IsValid)
      {
        _db.ComputerForum.Add(obj);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
      return View(obj);
    }
  }
}

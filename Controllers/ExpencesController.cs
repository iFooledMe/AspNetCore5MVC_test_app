using AspNetCore5MVC_test_app.Data;
using AspNetCore5MVC_test_app.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5MVC_test_app.Controllers
{
    public class ExpencesController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ExpencesController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Expence> expenceList = _db.Expences;
            return View(expenceList);
        }

        //GET-Create
        public IActionResult CreateExpence()
        {
            return View();
        }

        //POST-Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateExpence(Expence obj)
        {
            _db.Expences.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

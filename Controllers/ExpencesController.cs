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
            if (ModelState.IsValid)
            {
                _db.Expences.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }

        //GET-Delete
        public IActionResult DeleteExpence(int? id) //? = optional value
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Expences.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //POST-Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteExpencePost(int? id) //? = optional value
        {
            var obj = _db.Expences.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            _db.Expences.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }


        //GET-Update
        public IActionResult UpdateExpence(int? id) //? = optional value
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var obj = _db.Expences.Find(id);

            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);

        }

        //POST-Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateExpence(Expence obj)
        {
            if (ModelState.IsValid)
            {
                _db.Expences.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);

        }
    }
}

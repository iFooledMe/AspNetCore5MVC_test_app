using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCore5MVC_test_app.Controllers
{
    public class AppointmentController : Controller
    {
        [Route("Appointment")]
        [Route("Appointment/Index")]
        [Route("Details")]
        [Route("Details/{id?}")]
        
        
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return Ok($"you have entered id: {id}");
        }
    }
}

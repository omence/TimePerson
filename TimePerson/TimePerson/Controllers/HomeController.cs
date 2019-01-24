using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;
using TimePerson.Models;

namespace TimePerson.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int beginYear, int endYear)
        {
            return RedirectToAction("Results", new { beginYear, endYear });
        }

        [HttpGet]
        public IActionResult Results(int beginYear, int endYear)
        {
            return View(Models.TimePerson.GetPersons(beginYear, endYear));
        }
    }
}

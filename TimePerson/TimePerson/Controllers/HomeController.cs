using Microsoft.AspNetCore.Mvc;
using TimePerson.Models;

namespace TimePerson.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(int beginYear, int endYear)
        {
            return RedirectToAction("Results", new { beginYear, endYear });
        }

        public IActionResult Results(int beginYear, int endYear)
        {


        }
    }
}

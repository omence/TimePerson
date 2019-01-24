using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;
using TimePerson.Models;

namespace TimePerson.Controllers
{
    
    public class HomeController : Controller
    {
        /// <summary>
        /// Sends index page to the browser
        /// </summary>
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// gets input from the user and sends it to the Results method
        /// </summary>
        /// <param name="beginYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Index(int beginYear, int endYear)
        {
            return RedirectToAction("Results", new { beginYear, endYear });
        }

        /// <summary>
        /// Calls method from TimePerson class and sends results to results html
        /// </summary>
        /// <param name="beginYear"></param>
        /// <param name="endYear"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Results(int beginYear, int endYear)
        {
            return View(Models.TimePerson.GetPersons(beginYear, endYear));
        }
    }
}

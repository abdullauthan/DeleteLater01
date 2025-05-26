using System.Diagnostics;
using DeleteLater01.Data;
using DeleteLater01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DeleteLater01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var employee = new Employee();
            return View(employee);
        }

        [HttpPost]
        public IActionResult Index(Employee Employee)
        {
            return RedirectToAction("Privacy");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult AddressValidation(string Address, string Name)
        {
            if (string.IsNullOrEmpty(Name))
            {
                return Json($"Id is null.");

            }
            else if (Name == "AA" && Address == "AA")
            {
                return Json($"A user named {Name} already exists.");
            }

            return Json(true);
        }
    }
}

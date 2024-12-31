using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using view_and_controller.Models;

namespace view_and_controller.Controllers
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
            return View();
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
    }
}
public class HomeController : Controller
{
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Contact(string name, string email, string phone, string query)
    {
        if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) ||
            string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(query))
        {
            ViewBag.Message = "Form not Submitted! Please fill in all fields.";
        }
        else
        {
            ViewBag.Message = "Form Submitted";
        }

        return View("Index");
    }
}


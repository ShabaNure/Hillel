using LK23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LK23.Controllers
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
            Person person = new Person();
            return View(person);
        }
    }
}
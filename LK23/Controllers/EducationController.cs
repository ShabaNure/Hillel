using LK23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LK23.Controllers
{
    public class EducationController : Controller
    {
        private readonly ILogger<EducationController> _logger;

        public EducationController(ILogger<EducationController> logger)
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
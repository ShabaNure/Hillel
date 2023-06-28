using LK23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LK23.Controllers
{
    public class WorkController : Controller
    {
        private readonly ILogger<WorkController> _logger;

        public WorkController(ILogger<WorkController> logger)
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
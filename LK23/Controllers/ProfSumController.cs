using LK23.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LK23.Controllers
{
    public class ProfSumController : Controller
    {
        private readonly ILogger<ProfSumController> _logger;

        public ProfSumController(ILogger<ProfSumController> logger)
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
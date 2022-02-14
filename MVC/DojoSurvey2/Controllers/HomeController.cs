using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DojoSurvey2.Models;

namespace DojoSurvey2.Controllers
{
    public class HomeController : Controller
    {
        public static List<Survey> FormInfo = new List<Survey>();
        private readonly ILogger<HomeController> _logger;


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.FormInfo = FormInfo;
            return View();
        }

        [HttpPost("result")]
        public IActionResult Result(Survey newSurvey)
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Form submitted!");
                FormInfo.Add(newSurvey);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.FormInfo = FormInfo;
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

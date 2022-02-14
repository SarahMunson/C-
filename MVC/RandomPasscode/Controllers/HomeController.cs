using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RandomPasscode.Models;
using Microsoft.AspNetCore.Http;

namespace RandomPasscode.Controllers
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

        //     ViewBag.randomPasscode = HttpContext.Session.GetString("RandomPasscode");
            // string RandomPasscode = HttpContext.Session.GetString("randomPasscode");
            // Console.Write(RandomPasscode);
            ViewBag.randomPasscode = HttpContext.Session.GetString("randomPasscode");
            // Console.WriteLine(ViewBag.randomPasscode);
            return View();
            //return random passcode (passcode count)
        }

        [HttpGet("generate")]
        public IActionResult Generate()
        {
            HttpContext.Session.Clear();
            Random rand = new Random();
            string[] choices = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string passcode = "";
            for (var i = 0; i < 15; i++)
            {
                passcode += choices[rand.Next(choices.Length)];
            }
            HttpContext.Session.SetString("randomPasscode", passcode);



            //some logic for generating a number
            return RedirectToAction("Index");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

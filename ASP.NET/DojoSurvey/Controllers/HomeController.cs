using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        public static List<string> FormInfo = new List<string>();

        [HttpGet("")]
        public ViewResult Index()
        {
            ViewBag.heffamoose = "This is the viewbag";
            ViewBag.info = FormInfo;
            return View("Index");
        }

        [HttpPost("result")]
        // IActionResult allows us to return anything (such as View or RedirectToAction)
        public IActionResult Result(string name, string location, string language, string comment)
        {
            FormInfo.Add(name);
            FormInfo.Add(location);
            FormInfo.Add(language);
            FormInfo.Add(comment);
            ViewBag.info = FormInfo;
            return View("Result");
        }
    }
}
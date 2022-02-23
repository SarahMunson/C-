using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ChefsNDishes.Models;
using Microsoft.EntityFrameworkCore;

namespace ChefsNDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.AllChefs = _context.Chefs.Include(d => d.Dish).ToList();
            return View();
        }

        [HttpGet("addChef")]
        public IActionResult addChef()
        {
            return View();
        }

        [HttpPost("addChef")]
        public IActionResult addNewChef(Chef newChef)
        {
            if (ModelState.IsValid)
            {
                if ((DateTime.Now.Year - newChef.DOB.Year) < 18)
                {
                    ModelState.AddModelError("DOB", "Chef must be over 18 years of age");
                    return View("addChef");
                } 
                if((DateTime.Now.Year - newChef.DOB.Year) == 18)
                {
                    if (DateTime.Now.Month < newChef.DOB.Month)
                    {
                    ModelState.AddModelError("DOB", "Chef must be over 18 years of age");
                    return View("addChef");
                    }
                    if(DateTime.Now.Month == newChef.DOB.Month){
                        if (DateTime.Now.Day < newChef.DOB.Day)
                        {
                            ModelState.AddModelError("DOB", "Chef must be over 18 years of age");
                            return View("addChef");
                        }
                    }
                }
                if (newChef.DOB > DateTime.Now)
                {
                    ModelState.AddModelError("DOB", "Date must be in the past");
                    return View("addChef");
                }
                else
                {
                    _context.Chefs.Add(newChef);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            else
            {
                return View("addChef");
            }
        }

        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewBag.AllChefs = _context.Chefs.Include(d => d.Dish).ToList();
            return View();
        }

        [HttpGet("newDish")]
        public IActionResult newDish()
        {
            ViewBag.AllChefs = _context.Chefs.ToList();
            return View();
        }

        [HttpPost("newDish")]
        public IActionResult addNewDish(Dish newDish)
        {
            if (ModelState.IsValid)
            {
                _context.Dishes.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {
                ViewBag.AllChefs = _context.Chefs.Include(d => d.Dish).ToList();
                return View("newDish");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

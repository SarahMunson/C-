using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CRUDelicious.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDelicious.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;

        public HomeController(ILogger<HomeController> logger, MyContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            List<Dish> allDishes = _context.Dishes.ToList();
            ViewBag.allDishes = allDishes;
            return View();
        }

        [HttpGet("create")]
        public IActionResult NewDish()
        {
            return View("NewDish");
        }

        [HttpPost("NewDish")]
        public IActionResult CreateDish(Dish newDish)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newDish);
                _context.SaveChanges();
                return RedirectToAction("Index");
            } else {
                return View("create");
            }
        }

        [HttpGet("delete/{DishId}")]
        public IActionResult DeleteDish(int DishId)
        {
            Dish dishToDelete = _context.Dishes.SingleOrDefault(d => d.DishId == DishId);
            _context.Dishes.Remove(dishToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("edit/{DishId}")]
        public IActionResult EditDish(int DishId)
        {
            Dish dishToEdit = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            return View(dishToEdit);
        }

        [HttpPost("update/{DishId}")]
        public IActionResult UpdateDish(int DishId, Dish editedDish)
        {
            Dish original = _context.Dishes.FirstOrDefault(d => d.DishId == DishId);
            original.Name = editedDish.Name;
            original.Chef = editedDish.Chef;
            original.Calories = editedDish.Calories;
            original.Description = editedDish.Description;
            original.Tastiness = editedDish.Tastiness;
            original.UpdatedAt = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

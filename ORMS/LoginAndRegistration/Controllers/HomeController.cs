using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LoginAndRegistration.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MyContext _context;
        public HomeController(ILogger<HomeController> logger, MyContext dbcontext)
        {
            _logger = logger;
            _context = dbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User newUser)
        {
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetString("UserEmail", newUser.Email);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpGet("success")]
        public IActionResult Success()
        {
            if ( HttpContext.Session.GetString("UserEmail") != null)
            {
                {
                    string email = HttpContext.Session.GetString("UserEmail");
                    User loggedIn = _context.Users.FirstOrDefault(d => d.Email == email);
                    return View(loggedIn);
                }
            } else {
                return View("Index");
            }
        }

        [HttpPost("login")]
        public IActionResult Login(LogUser logUser)
        {
            if (ModelState.IsValid)
            {
                User userInDb = _context.Users.FirstOrDefault(s => s.Email == logUser.LEmail);
                if (userInDb == null)
                {
                    ModelState.AddModelError("LPassword", "Incorrect user information, please register");
                    return View("Index");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(logUser, userInDb.Password, logUser.LPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LPassword", "Incorrect user information, please register");
                    return View("Index");
                }
                HttpContext.Session.SetString("UserEmail", userInDb.Email);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }

        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

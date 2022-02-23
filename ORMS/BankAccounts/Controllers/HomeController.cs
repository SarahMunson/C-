using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankAccounts.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace BankAccounts.Controllers
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

        private bool inSession
            {
            get { return HttpContext.Session.GetInt32("userId") != null; }
        }
        private User loggedInUser
        {
            get
            {
                return _context.Users.Include(u => u.Transactions)
                    .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            }
        }

        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            HttpContext.Session.Clear();
            return View();
        }

        [HttpPost("register")]
        public IActionResult newUser(User newUser)
        {
            HttpContext.Session.Clear();
            if (ModelState.IsValid)
            {
                if (_context.Users.Any(u => u.Email == newUser.Email))
                {
                    ModelState.AddModelError("Email", "Email is already in use!");
                    return View("Index");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                newUser.Password = Hasher.HashPassword(newUser, newUser.Password);
                _context.Users.Add(newUser);
                _context.SaveChanges();
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("dashboard");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost("loginUser")]
        public IActionResult loginUser(LogUser loginUser)
        {
            if (ModelState.IsValid)
            {
                User person = _context.Users.FirstOrDefault(l => loginUser.LEmail == l.Email);
                if (person == null)
                {
                    ModelState.AddModelError("LPassword", "Incorrect User Information");
                    return View("Login");
                }
                PasswordHasher<LogUser> Hasher = new PasswordHasher<LogUser>();
                PasswordVerificationResult result = Hasher.VerifyHashedPassword(loginUser, person.Password, loginUser.LPassword);
                if (result == 0)
                {
                    ModelState.AddModelError("LPassword", "Incorrect user information");
                    return View("Login");
                }
                HttpContext.Session.SetInt32("UserId", person.UserId);
                return RedirectToAction("dashboard");
            }
            else
            {
                return View("Login");
            }
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("UserId") != null)
            {
                {
                    var user = loggedInUser;
                    ViewBag.User = user;
                    ViewBag.Transactions = _context.Transactions
                    .OrderByDescending(t => t.CreatedAt)
                    .Where(t => t.UserId == loggedInUser.UserId);
                    return View("Dashboard");
                }
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

        [HttpPost("money")]
        public IActionResult Money(Transaction trans)
        {
            if(ModelState.IsValid)
            {
                _context.Transactions.Add(trans);
                _context.SaveChanges();
                return RedirectToAction("dashboard");
            }
            var user = loggedInUser;
            ViewBag.User = user;
            ViewBag.Transactions = _context.Transactions
                .OrderByDescending(t => t.CreatedAt)
                .Where(t => t.UserId == loggedInUser.UserId);
            return View("dashboard");
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

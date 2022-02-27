using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WeddingPlanner.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;

namespace WeddingPlanner.Controllers
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
                return _context.Users.Include(u => u.Weddings)
                    .ThenInclude(p => p.Wedding)
                    .FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("UserId"));
            }
        }

        //Login and Registration
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
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
                HttpContext.Session.SetInt32("UserId", newUser.UserId);
                return RedirectToAction("dashboard");
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
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("dashboard");
            } else {
                return View("Index");
            }
        }

        //Dashboard View
        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if ( !inSession)
            {
                {
                    var loggedIn = loggedInUser;
                    ViewBag.User = _context.Users
                    .Include(p => p.Weddings)
                        .ThenInclude(p => p.Wedding)
                    .ToList();
                    ViewBag.Weddings = _context.Weddings
                    .Include(p => p.Guests)
                        .ThenInclude(p => p.User)
                    .ToList();
                    return View(loggedIn);
                }
            } else {
                return View("Index");
            }
        }


        //New wedding
        [HttpGet("newWedding")]
        public IActionResult NewWedding()
        {
            if (!inSession)
            {
                {
                    ViewBag.loggedIn = HttpContext.Session.GetInt32("UserId");
                    return View("NewWedding");
                }
            } else {
                return View("Index");
            }
        }

        [HttpPost("newWedding")]
        public IActionResult AddWedding(Wedding newWedding)
        {
            if(ModelState.IsValid)
            {
                if(newWedding.Date < DateTime.Now)
                {
                    ModelState.AddModelError("Date", "Date must be in the future");
                    return View("NewWedding");
                }
                _context.Add(newWedding);
                _context.SaveChanges();
                return RedirectToAction("dashboard");
            } else {
                return View("NewWedding");
            }
        }


        //One wedding
        [HttpGet("oneWedding/{wid}")]
        public IActionResult OneWedding(int wid)
        {
            if (!inSession)
            {
                Wedding OneWedding = _context.Weddings
                .Include(p => p.Guests)
                    .ThenInclude(p => p.User)
                .FirstOrDefault(p => p.WeddingId == wid);
                return View(OneWedding);
            } else {
                return View("Index");
            }
        }


        //RSVP
        [HttpPost("RSVP")]
        public IActionResult NewGuest(Guest newGuest)
        {
            if(ModelState.IsValid)
            {
                _context.Add(newGuest);
                _context.SaveChanges();
                return RedirectToAction("dashboard");
            } else {
                return View("Dashboard");
            }
        }


        //unRSVP
        [HttpPost("unRSVP")]
        public IActionResult unRSVP(Guest unRSVP)
        {
            if(!inSession)
            {
                Guest badFriend = _context.Guests
                .FirstOrDefault(p => p.UserId == unRSVP.UserId && p.WeddingId == unRSVP.WeddingId);
                _context.Guests.Remove(badFriend);
                _context.SaveChanges();
                return RedirectToAction("Dashboard");
            } else {
                return View("Index");
            }
        }


        //Delete
        [HttpGet("delete/{wid}")]
        public IActionResult DeleteWedding(int wid)
        {
            if (inSession)
            {
                return RedirectToAction("Index");
            }
            Wedding CancelWedding = _context.Weddings
            .SingleOrDefault(p => p.WeddingId == wid);
            _context.Weddings.Remove(CancelWedding);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }


        //logout
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

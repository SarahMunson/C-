using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            ViewBag.allWomens = _context.Leagues
                .Where(l => l.Name.Contains("Womens"));
            ViewBag.Hockey=  _context.Leagues
                .Where(l => l.Sport.Contains("Hockey"));
            ViewBag.notFootball=_context.Leagues
                .Where(l => !l.Sport.Contains("Football"));
            ViewBag.conferences=_context.Leagues
                .Where(l => l.Name.Contains("Conference"));
            ViewBag.atlantic=_context.Leagues
                .Where(l => l.Name.Contains("Atlantic"));
            ViewBag.dallas=_context.Teams
                .Where(t => t.Location.Contains("Dallas"));
            ViewBag.raptors=_context.Teams
                .Where(t => t.TeamName.Contains("Raptors"));
            ViewBag.city=_context.Teams
                .Where(t => t.Location.Contains("City"));
            ViewBag.startsWithT=_context.Teams
                .Where(t => t.TeamName.Contains("T"));
            ViewBag.orderedByLocation=_context.Teams
                .OrderBy(t => t.Location);
            ViewBag.reverseOrderedByTeam=_context.Teams
                .OrderByDescending(t => t.TeamName);
            ViewBag.lastNameCoop=_context.Players
                .Where(p => p.LastName.Contains("Cooper"));
            ViewBag.firstNameJosh=_context.Players
                .Where(p => p.FirstName.Contains("Joshua"));
            ViewBag.allCoopNotJosh=_context.Players
                .Where(p => p.LastName.Contains("Cooper") && !p.FirstName.Contains("Joshua"));
            ViewBag.allAlexOrWyatt=_context.Players
                .Where(p => p.FirstName.Contains("Alexander") || p.FirstName.Contains("Wyatt"));

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}
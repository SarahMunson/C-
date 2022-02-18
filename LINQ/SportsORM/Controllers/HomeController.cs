using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;
using Microsoft.EntityFrameworkCore;


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
            ViewBag.AtlSoccer = _context.Teams.Include(l => l.CurrLeague)
            .Where(f => f.CurrLeague.Name == "Atlantic Soccer Conference");
            ViewBag.PenguinsPlayers = _context.Players.Include(t => t.CurrentTeam)
            .Where(c => c.CurrentTeam.TeamName == "Penguins");
            ViewBag.IntnlBaseballConf = _context.Teams.Where(l => l.CurrLeague.Name == "International Collegiate Baseball Conference").Include(l => l.CurrentPlayers)
            .ToList();
            ViewBag.Lopez = _context.Teams.Where(l => l.CurrLeague.Name == "American Conference of Amateur Football").Include(p => p.CurrentPlayers);
            ViewBag.AllFootball = _context.Teams.Where(l => l.CurrLeague.Name.Contains("Football")).Include(p => p.CurrentPlayers);
            ViewBag.AllSophias = _context.Teams.Include(c => c.CurrentPlayers);
            ViewBag.AllFLores = _context.Teams.Include(c => c.CurrentPlayers);
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}
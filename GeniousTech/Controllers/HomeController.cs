
using GeniousTech.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeniousTech.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.Take(3).ToListAsync();
            var projects = await _context.Projects.OrderByDescending(p => p.CompletedOn).Take(3).ToListAsync();
            var team = await _context.TeamMembers.Take(3).ToListAsync();

            ViewBag.Services = services;
            ViewBag.Projects = projects;
            ViewBag.Team = team;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}

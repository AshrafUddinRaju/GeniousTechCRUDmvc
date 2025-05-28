using GeniousTech.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeniousTech.Web.Controllers
{
    public class ProjectsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var projects = await _context.Projects
                .OrderByDescending(p => p.CompletedOn)
                .ToListAsync();

            return View(projects);
        }
    }
}

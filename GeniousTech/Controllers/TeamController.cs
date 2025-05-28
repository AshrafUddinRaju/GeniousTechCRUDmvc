using GeniousTech.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeniousTech.Web.Controllers
{
    public class TeamController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var members = await _context.TeamMembers.ToListAsync();
            return View(members);
        }
    }
}

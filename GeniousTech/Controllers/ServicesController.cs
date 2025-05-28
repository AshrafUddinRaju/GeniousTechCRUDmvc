using GeniousTech.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeniousTech.Web.Controllers
{
    public class ServicesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ServicesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var services = await _context.Services.ToListAsync();
            return View(services);
        }
    }
}

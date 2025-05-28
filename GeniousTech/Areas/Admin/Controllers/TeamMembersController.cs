using GeniousTech.Models;
using GeniousTech.Web.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeniousTech.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamMembersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TeamMembersController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.TeamMembers.ToListAsync());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeamMember teamMember)
        {
            if (ModelState.IsValid)
            {
                _context.Add(teamMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamMember);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var member = await _context.TeamMembers.FindAsync(id);
            if (member == null)
                return NotFound();

            return View(member);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(TeamMember teamMember)
        {
            if (ModelState.IsValid)
            {
                _context.Update(teamMember);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(teamMember);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var member = await _context.TeamMembers.FindAsync(id);
            if (member == null)
                return NotFound();

            return View(member);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var member = await _context.TeamMembers.FindAsync(id);
            if (member != null)
            {
                _context.TeamMembers.Remove(member);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}

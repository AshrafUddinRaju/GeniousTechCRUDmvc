using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GeniousTech.Models;
using GeniousTech.Web.Data;

namespace GeniousTech.Controllers
{
    [Route("Contact")]
    public class ContactMessagesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ContactMessagesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /Contact
        [HttpGet("")]
        public IActionResult Create()
        {
            return View(); // Views/ContactMessages/Create.cshtml
        }

        // POST: /Contact
        [HttpPost("")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Email,Subject,Message")] ContactMessage contactMessage)
        {
            if (ModelState.IsValid)
            {
                contactMessage.SentAt = DateTime.Now;
                _context.Add(contactMessage);
                await _context.SaveChangesAsync();

                ViewBag.Success = "Your message has been sent successfully!";
                ModelState.Clear(); // clear form fields
                return View();
            }

            return View(contactMessage);
        }
    }
}

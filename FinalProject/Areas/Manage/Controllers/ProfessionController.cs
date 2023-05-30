using FinalProject.DAL;
using FinalProject.Models;
using FinalProject.Utilities.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Areas.Manage.Controllers
{
       [Area("Manage")]
       public class ProfessionController : Controller
         {
        private readonly AppDbContext _context;
        public ProfessionController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Profession> professions = await _context.Professions.ToListAsync();
            return View(professions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Profession profession)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Professions.AddAsync(profession);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1) return BadRequest();

            Profession existed = await _context.Professions.FirstOrDefaultAsync(p => p.Id == id);
            if (existed == null) return NotFound();

            return View(existed);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Profession profession)
        {
            if (id == null || id < 1) return BadRequest();

            Profession existed = await _context.Professions.FirstOrDefaultAsync(p => p.Id == id);
            if (existed == null) return NotFound();
            if (!ModelState.IsValid)
            {
                return View(existed);
            }
            existed.Name = profession.Name;
            existed.Description = profession.Description;
            existed.Image = profession.Image;
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id < 1) return BadRequest();

            Profession existed = await _context.Professions.FirstOrDefaultAsync(p => p.Id == id);
            if (existed == null) return NotFound();

            _context.Professions.Remove(existed);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}


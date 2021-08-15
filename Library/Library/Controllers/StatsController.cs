using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Library.Data;
using Library.Models;

namespace Library.Controllers
{
    public class StatsController : Controller
    {
        private readonly LibraryContext _context;

        public StatsController(LibraryContext context)
        {
            _context = context;
        }

        // GET: Stats
        public async Task<IActionResult> Index()
        {
            return View(await _context.Stats.ToListAsync());
        }

        // GET: Stats/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats
                .FirstOrDefaultAsync(m => m.StatsId == id);
            if (stats == null)
            {
                return NotFound();
            }

            return View(stats);
        }

        // GET: Stats/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Stats/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StatsId,Name,Read")] Stats stats)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stats);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(stats);
        }

        // GET: Stats/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats.FindAsync(id);
            if (stats == null)
            {
                return NotFound();
            }
            return View(stats);
        }

        // POST: Stats/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StatsId,Name,Read")] Stats stats)
        {
            if (id != stats.StatsId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(stats);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StatsExists(stats.StatsId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(stats);
        }

        // GET: Stats/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var stats = await _context.Stats
                .FirstOrDefaultAsync(m => m.StatsId == id);
            if (stats == null)
            {
                return NotFound();
            }

            return View(stats);
        }

        // POST: Stats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var stats = await _context.Stats.FindAsync(id);
            _context.Stats.Remove(stats);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StatsExists(int id)
        {
            return _context.Stats.Any(e => e.StatsId == id);
        }
    }
}

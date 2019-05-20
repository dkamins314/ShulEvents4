using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShulEvents4.Data;
using ShulEvents4.ViewModels;

namespace ShulEvents4.Controllers
{
    public class CreateYearlyEventsViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CreateYearlyEventsViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: CreateYearlyEventsViewModels
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.CreateYearlyEventsViewModel.Include(c => c.User);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: CreateYearlyEventsViewModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createYearlyEventsViewModel = await _context.CreateYearlyEventsViewModel
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (createYearlyEventsViewModel == null)
            {
                return NotFound();
            }

            return View(createYearlyEventsViewModel);
        }

        // GET: CreateYearlyEventsViewModels/Create
        public IActionResult Create()
        {
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: CreateYearlyEventsViewModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserId,StartingDate,StartTime,EndingDate,EndTime,SpecialEvents,SpecialShabassos,Months,Parshios,LifeEvents,EventDescription")] CreateYearlyEventsViewModel createYearlyEventsViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(createYearlyEventsViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", createYearlyEventsViewModel.UserId);
            return View(createYearlyEventsViewModel);
        }

        // GET: CreateYearlyEventsViewModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createYearlyEventsViewModel = await _context.CreateYearlyEventsViewModel.FindAsync(id);
            if (createYearlyEventsViewModel == null)
            {
                return NotFound();
            }
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", createYearlyEventsViewModel.UserId);
            return View(createYearlyEventsViewModel);
        }

        // POST: CreateYearlyEventsViewModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserId,StartingDate,StartTime,EndingDate,EndTime,SpecialEvents,SpecialShabassos,Months,Parshios,LifeEvents,EventDescription")] CreateYearlyEventsViewModel createYearlyEventsViewModel)
        {
            if (id != createYearlyEventsViewModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(createYearlyEventsViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CreateYearlyEventsViewModelExists(createYearlyEventsViewModel.Id))
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
            ViewData["UserId"] = new SelectList(_context.Users, "Id", "Id", createYearlyEventsViewModel.UserId);
            return View(createYearlyEventsViewModel);
        }

        // GET: CreateYearlyEventsViewModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var createYearlyEventsViewModel = await _context.CreateYearlyEventsViewModel
                .Include(c => c.User)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (createYearlyEventsViewModel == null)
            {
                return NotFound();
            }

            return View(createYearlyEventsViewModel);
        }

        // POST: CreateYearlyEventsViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var createYearlyEventsViewModel = await _context.CreateYearlyEventsViewModel.FindAsync(id);
            _context.CreateYearlyEventsViewModel.Remove(createYearlyEventsViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CreateYearlyEventsViewModelExists(int id)
        {
            return _context.CreateYearlyEventsViewModel.Any(e => e.Id == id);
        }
    }
}

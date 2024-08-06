using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.Data;
using MVC.Models;

namespace MVC.Controllers
{
    public class ProsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Pros
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pros.ToListAsync());
        }

        // GET: Pros/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmployeeId,EmployeeName,AmountPaid,EventName")] Pro pro)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pro);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pro);
        }

        // GET: Pros/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Pros == null)
            {
                return NotFound();
            }

            var pro = await _context.Pros.FindAsync(id);
            if (pro == null)
            {
                return NotFound();
            }
            return View(pro);
        }

        // POST: Pros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("EmployeeId,EmployeeName,AmountPaid,EventName")] Pro pro)
        {
            if (id != pro.EmployeeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pro);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProExists(pro.EmployeeId))
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
            return View(pro);
        }

        // GET: Pros/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Pros == null)
            {
                return NotFound();
            }

            var pro = await _context.Pros
                .FirstOrDefaultAsync(m => m.EmployeeId == id);
            if (pro == null)
            {
                return NotFound();
            }

            return View(pro);
        }

        // POST: Pros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pro = await _context.Pros.FindAsync(id);
            if (pro != null)
            {
                _context.Pros.Remove(pro);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult UE()
        {
            return View();
        }
        public IActionResult Dashbd()
        {
            return View();
        }
        private bool ProExists(string id)
        {
            return _context.Pros.Any(e => e.EmployeeId == id);
        }
    }
}

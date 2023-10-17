using CropsAppMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CropsAppMVC.Controllers
{
    public class CropsController : Controller
    {
        private readonly CropDatabaseContext _context;

        public CropsController(CropDatabaseContext context)
        {
            _context = context;
        }

        // GET: Crops
        public async Task<IActionResult> Index()
        {
              return _context.Crops != null ? 
                          View(await _context.Crops.ToListAsync()) :
                          Problem("Entity set 'CropDatabaseContext.Crops'  is null.");
        }

        // GET: Crops/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Crops == null)
            {
                return NotFound();
            }

            var crop = await _context.Crops
                .FirstOrDefaultAsync(m => m.Id == id);
            if (crop == null)
            {
                return NotFound();
            }

            return View(crop);
        }

        // GET: Crops/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Crops/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CropName,CropYield,CropExpenses,CropIncome")] Crop crop)
        {
            if (ModelState.IsValid)
            {
                _context.Add(crop);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(crop);
        }

        // GET: Crops/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Crops == null)
            {
                return NotFound();
            }

            var crop = await _context.Crops.FindAsync(id);
            if (crop == null)
            {
                return NotFound();
            }
            return View(crop);
        }

        // POST: Crops/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CropName,CropYield,CropExpenses,CropIncome")] Crop crop)
        {
            if (id != crop.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(crop);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CropExists(crop.Id))
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
            return View(crop);
        }

        // GET: Crops/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Crops == null)
            {
                return NotFound();
            }

            var crop = await _context.Crops
                .FirstOrDefaultAsync(m => m.Id == id);
            if (crop == null)
            {
                return NotFound();
            }

            return View(crop);
        }

        // POST: Crops/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Crops == null)
            {
                return Problem("Entity set 'CropDatabaseContext.Crops'  is null.");
            }
            var crop = await _context.Crops.FindAsync(id);
            if (crop != null)
            {
                _context.Crops.Remove(crop);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CropExists(int id)
        {
          return (_context.Crops?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

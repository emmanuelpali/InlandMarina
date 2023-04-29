using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InlandMarina.Data;
using InlandMarina.Models;

namespace InlandMarina.Controllers
{
    public class LeasesController : Controller
    {
        private readonly InlandMarinaContext _context;

        public LeasesController(InlandMarinaContext context)
        {
            _context = context;
        }

        // GET: Leases
        public async Task<IActionResult> Index()
        {
            var inlandMarinaContext = _context.Leases.Include(l => l.Customer).Include(l => l.Slip);
            return View(await inlandMarinaContext.ToListAsync());
        }

        //Ger customer leases
        public ActionResult MyLeases()
        {
            if(User.Identity.Name != null)
            {
                List<Lease> cusLeases = LeaseManager.GetCustomerLeases(_context, User.Identity.Name);
                return View(cusLeases);
            }
            return View("Login", "Account");
        }

        // GET: Leases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Leases == null)
            {
                return NotFound();
            }

            var lease = await _context.Leases
                .Include(l => l.Customer)
                .Include(l => l.Slip)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lease == null)
            {
                return NotFound();
            }

            return View(lease);
        }

        // GET: Leases/Create
        public IActionResult Create(int slipId, string customerId)
        {

            int custId = CustomerManager.FindCustomer(customerId, _context).ID;
            ViewData["CustomerID"] = custId;
            ViewData["SlipID"] = slipId;
            return View();
        }

        // POST: Leases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,SlipID,CustomerID")] Lease lease)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lease);
                await _context.SaveChangesAsync();
                return RedirectToAction("Myleases");
            }
            return View("index", "Customers");
        }

        // GET: Leases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Leases == null)
            {
                return NotFound();
            }

            var lease = await _context.Leases.FindAsync(id);
            if (lease == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "City", lease.CustomerID);
            ViewData["SlipID"] = new SelectList(_context.Slips, "ID", "ID", lease.SlipID);
            return View(lease);
        }

        // POST: Leases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,SlipID,CustomerID")] Lease lease)
        {
            if (id != lease.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lease);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LeaseExists(lease.ID))
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
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "City", lease.CustomerID);
            ViewData["SlipID"] = new SelectList(_context.Slips, "ID", "ID", lease.SlipID);
            return View(lease);
        }

        // GET: Leases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Leases == null)
            {
                return NotFound();
            }

            var lease = await _context.Leases
                .Include(l => l.Customer)
                .Include(l => l.Slip)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lease == null)
            {
                return NotFound();
            }

            return View(lease);
        }

        // POST: Leases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Leases == null)
            {
                return Problem("Entity set 'InlandMarinaContext.Leases'  is null.");
            }
            var lease = await _context.Leases.FindAsync(id);
            if (lease != null)
            {
                _context.Leases.Remove(lease);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("MyLeases");
        }

        private bool LeaseExists(int id)
        {
            return (_context.Leases?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}

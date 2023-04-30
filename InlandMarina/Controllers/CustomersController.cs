using InlandMarina.Data;
using InlandMarina.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace InlandMarina.Controllers
{
    [Authorize]
    public class CustomersController : Controller
    {
        
        private readonly InlandMarinaContext _context; // database context for inlandMarina

        // context gets  injected to the constructor
        public CustomersController(InlandMarinaContext context)
        {
            _context = context;
        }
        // GET: CustomerController
        public ActionResult Index()
        {
            Customer customer = CustomerManager.FindCustomer(User.Identity.Name, _context);
            ViewBag.CustomerData = new List<Lease>(customer.Leases.ToList());
            return View(customer);
        }


       
        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }
        [AllowAnonymous]
        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }
        [AllowAnonymous]
        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Phone,City,Username,Password")] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to add Customer");
            }
            return View(customer);
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DailyShopStoreReport.Data;
using DailyShopStoreReport.Models;
using Microsoft.AspNetCore.Authorization;

namespace DailyShopStoreReport.Controllers
{
    [Authorize]
    public class IncomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IncomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Income
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Incomes.Include(i => i.AppUser);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Income/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes
                .Include(i => i.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (income == null)
            {
                return NotFound();
            }

            return View(income);
        }

        // GET: Income/Create
        public IActionResult Create()
        {
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name");
            return View();
        }

        // POST: Income/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IncomeName,AppUserId,IdentityRoleId,Type,Amount,ChequeNo,BankName,Particular,Date,IsApproved")] Income income)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Incomes.Add(income);
                    await _context.SaveChangesAsync();

                    TempData["success"] = "Data Submited!";
                    ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName", income.AppUserId);
                    return RedirectToAction("Show", "Income");
                    //return RedirectToAction(nameof(Index));
                }
                catch (Exception e)
                {
                    TempData["error"] = e.Message;
                    return View();
                }
                //_context.Add(income);
                //await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
            }
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name");
            return View(income);
        }

        // GET: Income/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes.FindAsync(id);
            if (income == null)
            {
                return NotFound();
            }
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name");
            return View(income);
        }

        // POST: Income/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IncomeName,AppUserId,IdentityRoleId,Type,Amount,ChequeNo,BankName,Particular,Date,IsApproved")] Income income)
        {
            if (id != income.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(income);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IncomeExists(income.Id))
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
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name"); return View(income);
        }



        // GET: Income/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var income = await _context.Incomes
                .Include(i => i.AppUser)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (income == null)
            {
                return NotFound();
            }

            return View(income);
        }

        // POST: Income/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var income = await _context.Incomes.FindAsync(id);
            _context.Incomes.Remove(income);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IncomeExists(int id)
        {
            return _context.Incomes.Any(e => e.Id == id);
        }
        [HttpGet]
        public IActionResult Store()
        {
            if (User.IsInRole("JrAccountant"))
            {
                return RedirectToAction("Index", "Dashboard");
            }
            return View();
        }


        public IActionResult Store(Income income)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Incomes.Add(income);
                    _context.SaveChanges();

                    TempData["success"] = "Data Submited!";
                    return RedirectToAction("Show", "Income");
                }
                catch (Exception e)
                {
                    TempData["error"] = e.Message;
                    return View();
                }

            }
            return View();
        }


        [HttpGet]
        public IActionResult Show()
        {
            List<Income> incomes = _context.Incomes.Where(i => i.IsApproved == false).ToList();
            return View(incomes);
        }

        [HttpPost]
        public IActionResult Approve(int[] ids)
        {
            try
            {
                var entity = _context.Incomes.Where(i => ids.Contains(i.Id));

                foreach (var e in entity)
                {
                    e.IsApproved = true;
                    _context.Incomes.Update(e);
                }
                _context.SaveChanges();

                TempData["success"] = "Data approved!";

                return Json(new { success = true, redirecturl = Url.Action("Show", "Income") });
            }
            catch (Exception e)
            {
                TempData["success"] = e.Message;
                return Json(new { success = false, message = e.Message });
            }
        }
    }
}
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
    public class ExpController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ExpController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Expense
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Expenses.ToListAsync();
            return View(await applicationDbContext);
        }

        // GET: Expense/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var expense = await _context.Expenses
                               .FirstOrDefaultAsync(m => m.Id == id);
            if (expense == null)
            {
                return NotFound();
            }

            return View(expense);
        }



        //// GET: Expense/Create
        //public IActionResult Create()
        //{
        //    ViewData["AppRoleId"] = new SelectList(_context.AppRole, "Id", "Id");
        //    return View();
        //}

        //// POST: Expense/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,ExpenseName,AppUserId,AppRoleId,Type,Amount,ChequeNo,BankName,Particular,Date,IsApproved")] Expense expense)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(expense);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AppRoleId"] = new SelectList(_context.AppRole, "Id", "Id", expense.AppRoleId);
        //    return View(expense);
        //}

        //// GET: Expense/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var expense = await _context.Expenses.FindAsync(id);
        //    if (expense == null)
        //    {
        //        return NotFound();
        //    }
        //    ViewData["AppRoleId"] = new SelectList(_context.AppRole, "Id", "Id", expense.AppRoleId);
        //    return View(expense);
        //}

        //// POST: Expense/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,ExpenseName,AppUserId,AppRoleId,Type,Amount,ChequeNo,BankName,Particular,Date,IsApproved")] Expense expense)
        //{
        //    if (id != expense.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(expense);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!ExpenseExists(expense.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["AppRoleId"] = new SelectList(_context.AppRole, "Id", "Id", expense.AppRoleId);
        //    return View(expense);
        //}

        //// GET: Expense/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var expense = await _context.Expenses
        //        .Include(e => e.AppRole)
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (expense == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(expense);
        //}

        //// POST: Expense/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var expense = await _context.Expenses.FindAsync(id);
        //    _context.Expenses.Remove(expense);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool ExpenseExists(int id)
        //{
        //    return _context.Expenses.Any(e => e.Id == id);
        //}
        [HttpGet]
        public IActionResult Store()
        {
            if (User.IsInRole("JrAccountant")) 
            {
                return RedirectToAction("Index", "Dashboard");
            }
            ViewData["AppUsersId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            return View();
        }

        [HttpPost]
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
            //ViewData["AppRoleId"] = new SelectList(_context.AppRole, "Id", "UserName");
            //ViewData["AppUsersId"] = new SelectList(_context.AppUsers, "Id", "UserName");
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

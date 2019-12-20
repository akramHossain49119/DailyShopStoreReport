using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DailyShopStoreReport.Data;
using DailyShopStoreReport.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DailyShopStoreReport.Controllers
{
    [Authorize]
    public class ExpenseController : Controller
    {


        private readonly ApplicationDbContext _context;

        public ExpenseController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Store()
        {
            //if (User.IsInRole("SrAccountant"))
            //{
            //    return RedirectToAction("Index", "Dashboard");
            //}

            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult Store([Bind("ExpenseName,AppUserId,IdentityRoleId,Type,Amount,ChequeNo,BankName,Particular,Date,IsApproved")]Expense expense)  
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Expenses.Add(expense);
                    _context.SaveChanges();

                    TempData["success"] = "Data Submited!";
                    return RedirectToAction("Show", "Expense");
                }
                catch (Exception e)
                {
                    TempData["error"] = e.Message;
                    return View();
                }

            }
            ViewData["AppUserId"] = new SelectList(_context.AppUsers, "Id", "UserName");
            ViewData["IdentityRoleId"] = new SelectList(_context.Roles, "Id", "Name");

            return View();
        }

        [HttpGet]
        public IActionResult Show()  
        {
            List<Expense> expenses = _context.Expenses.Where(e => e.IsApproved == false).ToList();
            return View(expenses);
        }

        [HttpPost]
        public IActionResult Approve(int[] ids)
        {
            try
            {
                var entity = _context.Expenses.Where(i => ids.Contains(i.Id));

                foreach (var e in entity)
                {
                    e.IsApproved = true;
                    _context.Expenses.Update(e);
                }
                _context.SaveChanges();

                TempData["success"] = "Data approved!";

                return Json(new { success = true, redirecturl = Url.Action("Show", "Expense") });
            }
            catch (Exception e)
            {
                TempData["success"] = e.Message;
                return Json(new { success = false, message = e.Message });
            }

        }
    }
}
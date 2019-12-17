using System;
using System.Collections.Generic;
using System.Linq;
using DailyShopStoreReport.Data;
using DailyShopStoreReport.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Data.SqlClient;

namespace DailyShopStoreReport.Controllers
{
    [Authorize]
    public class IncController : Controller
    {
        private readonly ApplicationDbContext _context; 
        public IncController(ApplicationDbContext context)
        {
            _context = context;
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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using DailyShopStoreReport.Models;
using DailyShopStoreReport.Data;
using Microsoft.EntityFrameworkCore;


namespace DailyShopStoreReport.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {

        private readonly ApplicationDbContext _context;
        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IActionResult ViewMonthlyIncome()
        //{
        //    ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
        //    var model = _context.Incomes.ToList();
        //    return View(model);
        //}


        //[HttpPost]
         [HttpGet]
        public IActionResult ViewMonthlyIncome(string month = "", string year = "")
        {
            if (string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
            {
                month = DateTime.Now.ToString("MMMM");
                year = DateTime.Now.ToString("yyyy"); 
            }
            //List<Income> incomes = _context.Incomes.Where(i => i.IsApproved && i.PerDate.Month.ToString("MMMM") == month && i.PerDate.Year.ToString("yyyy") == year).ToList();
            List<Income> incomes = _context.Incomes.Where(i => i.IsApproved && i.PerDate.Month.ToString() == month && i.PerDate.Year.ToString() == year).ToList();

            //List<Income> incomes = _context.Incomes
            //    .Where(i => i.IsApproved)
            //    .Where(i => i.PerDate.ToString("MMMM") == month && i.PerDate.ToString("yyyy") == year).ToList();

            //IQueryable<Transaction> transactions = _dbContext.Transactions
            //.Include(i => i.User)
            //.Include(i => i.Client)
            //.Where(a => a.Timestamp >= start && a.Timestamp <= end && a.Status == TransactionStatus.Failed && a.Client.ClientCode == clientCode);


            //List<Expense> expenses = _context.Expenses
            //.Where(i => i.IsApproved)
            //.Where(i => i.Date.ToString("MMMM") == month &&
            //            i.Date.ToString("yyyy") == year).ToList();

            ViewBag.Month = month;
            ViewBag.Year = year;

            ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
            return View(incomes);
        }


        //public IActionResult ViewMonthlyExpense()
        //{
        //    ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
        //    var model = _context.Expenses.ToList();
        //    return View(model); 
        //}

        //[HttpPost]

        [HttpGet]
        public IActionResult ViewMonthlyExpense(string month = "", string year = "")
        {
            if (string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
            {
                month = DateTime.Now.ToString("MMMM");
                year = DateTime.Now.ToString("yyyy");
            }
            // List<Expense> expenses = _context.Expenses.Where(i => i.IsApproved && i.Date.ToString("MMMM") == month && i.Date.ToString("yyyy") == year).ToList();
            List<Expense> expenses = _context.Expenses
               .Where(i => i.IsApproved && i.PerDate.Month.ToString() == month && i.PerDate.Year.ToString() == year).ToList();

            ViewBag.Month = month;
            ViewBag.Year = year;

            //DateTimeFormatInfo dinfo = new DateTimeFormatInfo();
            //dinfo.GetMonthName.ToString();

            ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
            return View(expenses);
        }

        //public IActionResult ViewYearlyProfit()
        //{
        //    ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
        //    var model = _context.YearlyDataModelViews.ToList();
        //    return View(model); 
        //}

      
        public IActionResult ViewYearlyProfit(int? year)
        {
            if (year == null)
            {
                year = DateTime.Now.Year;
            }
            var income = _context.Incomes
                .Where(x => x.IsApproved)
                .Where(x => x.PerDate.Year.Equals(year))
                .AsEnumerable()
                .GroupBy(x => x.PerDate.Month)
                .Select(a => new
                {
                    month = a.Key,
                    amount = a.Sum(r => r.Amount),
                });

            var expense = _context.Expenses
                .Where(x => x.IsApproved)
                .Where(x => x.PerDate.Year.Equals(year))
                .GroupBy(x => x.PerDate.Month)
                .Select(a => new
                {
                    month = a.Key,
                    amount = a.Sum(r => r.Amount),
                });


            var leftJoin = (from i in income
                            join e in expense on i.month equals e.month into temp
                            from e in temp.DefaultIfEmpty()
                            select new
                            {
                                MonthId = i.month,
                                IncomeAmount = i.amount,
                                ExpenseAmount = e != null ? e.amount : 0
                            });

            var rightJoin = (from e in expense
                             join i in income on e.month equals i.month into temp
                             from i in temp.DefaultIfEmpty()
                             select new
                             {
                                 MonthId = e.month,
                                 IncomeAmount = i != null ? i.amount : 0,
                                 ExpenseAmount = e.amount
                             });

            List<YearlyDataModelView> data = leftJoin.Union(rightJoin).Select(x => new YearlyDataModelView()
            {
                MonthId = x.MonthId,
                IncomeAmount = x.IncomeAmount,
                ExpenseAmount = x.ExpenseAmount,
                Profit = x.IncomeAmount - x.ExpenseAmount,
            }).OrderBy(x => x.MonthId).ToList();

            ViewBag.Year = year;
            ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");

            return View(data);
        }


        /// <summary>
        /// ////////////
        /// </summary>
        /// <param name="month"></param>
        /// <param name="year"></param>
        /// <returns></returns>

        //public IActionResult ViewMonthlyIncome(string month = "", string year = "")
        //{
        //    if (string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
        //    {
        //        month = DateTime.Now.ToString("MMMM");
        //        year = DateTime.Now.ToString("yyyy");
        //    }

        //    List<Income> incomes = _context.Incomes.Where(i => i.IsApproved)
        //        .Where(i => i.Date.ToString("MMMM") == month &&
        //            i.Date.ToString("yyyy") == year).ToList();

        //    ViewBag.Month = month;
        //    ViewBag.Year = year;

        //    return View(incomes);
        //}

        //[HttpGet]
        //public IActionResult ViewMonthlyExpense(string month = "", string year = "")
        //{
        //    if (string.IsNullOrEmpty(month) && string.IsNullOrEmpty(year))
        //    {
        //        month = DateTime.Now.ToString("MMMM");
        //        year = DateTime.Now.ToString("yyyy");
        //    }
        //    List<Expense> expenses = _context.Expenses
        //        .Where(i => i.IsApproved)
        //        .Where(i => i.Date.ToString("MMMM") == month &&
        //                    i.Date.ToString("yyyy") == year).ToList();

        //    ViewBag.Month = month;
        //    ViewBag.Year = year;

        //    return View(expenses);
        //}

        //public IActionResult ViewYearlyProfit(int? year)
        //{
        //    if (year == null)
        //    {
        //        year = DateTime.Now.Year;
        //    }
        //    var income = _context.Incomes
        //        .Where(x => x.IsApproved)
        //        .Where(x => x.Date.Year.Equals(year))
        //        .GroupBy(x => x.Date.Month)
        //        .Select(a => new
        //        {
        //            month = a.Key,
        //            amount = a.Sum(r => r.Amount),
        //        });

        //    var expense = _context.Expenses
        //        .Where(x => x.IsApproved)
        //        .Where(x => x.Date.Year.Equals(year))
        //        .GroupBy(x => x.Date.Month)
        //        .Select(a => new
        //        {
        //            month = a.Key,
        //            amount = a.Sum(r => r.Amount),
        //        });


        //    var leftJoin = (from i in income
        //                    join e in expense on i.month equals e.month into temp
        //                    from e in temp.DefaultIfEmpty()
        //                    select new
        //                    {
        //                        MonthId = i.month,
        //                        IncomeAmount = i.amount,
        //                        ExpenseAmount = e != null ? e.amount : 0
        //                    });

        //    var rightJoin = (from e in expense
        //                     join i in income on e.month equals i.month into temp
        //                     from i in temp.DefaultIfEmpty()
        //                     select new
        //                     {
        //                         MonthId = e.month,
        //                         IncomeAmount = i != null ? i.amount : 0,
        //                         ExpenseAmount = e.amount
        //                     });

        //    List<YearlyDataModelView> data = leftJoin.Union(rightJoin).Select(x => new YearlyDataModelView()
        //    {
        //        MonthId = x.MonthId,
        //        IncomeAmount = x.IncomeAmount,
        //        ExpenseAmount = x.ExpenseAmount,
        //        Profit = x.IncomeAmount - x.ExpenseAmount,
        //    }).OrderBy(x => x.MonthId).ToList();

        //    ViewBag.Year = year;

        //    return View(data);
        //}
    }
}
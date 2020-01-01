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
using Microsoft.Data.SqlClient;
using Microsoft.Web.Administration;
using OfficeOpenXml.FormulaParsing.Excel.Functions.DateTime;

namespace DailyShopStoreReport.Controllers
{
    [Authorize]
    public class ReportController : Controller
    {
        private readonly string connectionString = "Server=AKRAM;Database=AbcdefghDb;user id=Akram; password=akram;";
        private readonly ApplicationDbContext _context;
 
        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult ViewMonthlyIncome()
        {
            ViewBag.Years = GetAllYearList();
          
            string year = ""; 
            string month = "";

            int monthValue = 0; 
            int yearhValue = 0;

            if (month == "Select Month ... ")
            {
                monthValue = 0;
            }
            else if (month == null || month == "")
            {
                monthValue = 0;
            }

            if (year == "Select Year ... ")
            {
                yearhValue = 0;
            }
            else if (year == null || year == "")
            {
                yearhValue = 0;
            }
            // var incomes = from c in _context.Incomes select c;

            var incomes = _context.Incomes
                        .Where(i => i.IsApproved)
                        .Where(i => i.PerDate.Month == monthValue)
                        .Where(i => i.PerDate.Year == yearhValue);

            return View(incomes.ToList());

        }

        [HttpPost]
        public IActionResult ViewMonthlyIncome(Income income, string year = "", string month = "")
        {

            int monthValue = 0;
            int yearhValue = 0; 
 
            //string Dobdat = Convert.ToDateTime(income.PerDate).ToString(); 
            //int Ddateln = Dobdat.Length;
            //string Month = Dobdat[Ddateln - 5].ToString() + Dobdat[Ddateln - 4].ToString();
            //string DYear = Dobdat[Ddateln - 10].ToString() + Dobdat[Ddateln - 9].ToString() + Dobdat[Ddateln - 8].ToString() + Dobdat[Ddateln - 7].ToString();

            if (month !=null|| month != "" )
            {
                if (month == "Select Month ... ")
                {
                    monthValue = 0;
                }
                else if(month == "January")
                {
                    monthValue = 1;
                }
                else if ( month == "February")
                {
                    monthValue = 2;
                }
                else if ( month == "March")
                {
                    monthValue = 3;
                }
                else if (month == "April")
                {
                    monthValue = 4;
                }
                else if ( month == "May")
                {
                    monthValue = 5;
                }
                else if (month == "June")
                {
                    monthValue = 6;
                }
                else if ( month == "July")
                {
                    monthValue = 7;
                }
                else if ( month == "August")
                {
                    monthValue = 8;
                }
                else if (month == "September")
                {
                    monthValue = 9;
                }
                else if ( month == "October")
                {
                    monthValue = 10;
                }
                else if ( month == "November")
                {
                    monthValue = 11;
                }
                else if ( month == "December")
                {
                    monthValue = 12;
                }
            }
            else if (month == null || month == "")
            {
                monthValue = 0;
            }

            if (year != null|| year != "")
            {
                yearhValue = Convert.ToInt32(year.ToString()); 
            }
            else if (year == "Select Year ... ")
            {
                yearhValue = 0;
            }
            else if(year == null || year == "")
            {
                yearhValue = 0; 
            }

           // var incomes= from c in _context.Incomes select c;

            var incomes = _context.Incomes
                            .Where(i => i.IsApproved)
                            .Where(i => i.PerDate.Month == monthValue)
                            .Where(i => i.PerDate.Year == yearhValue);

            //  ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
                
                ViewBag.Years = GetAllYearList();
                ViewBag.Month = month;
                ViewBag.Year = year;
               
                return View(incomes.ToList());

 
            //==================
            //List<Income> incomes = _context.Incomes.Where(i => i.IsApproved && i.PerDate.Month.ToString()== month && i.PerDate.Year.ToString() == year).ToList();
            ///------------------------------------------------------------------
            //List<Income> incomes = _context.Incomes.Where(i => i.IsApproved)
            //        .Where(i => i.PerDate.ToString("MMMM") == month &&
            //                    i.PerDate.ToString("yyyy") == year).ToList();
            ///=================================================================
            // List<Income> income= _context.Incomes.Where(c => c.IsApproved && c.PerDate.Year == year && c.PerDate.ToString("MM") == month).ToList();
            //===================================


        }



        [HttpGet] 
        public IActionResult ViewMonthlyExpense()
        {
            ViewBag.Years = GetAllYearList();

            string year = "";
            string month = "";

            int monthValue = 0;
            int yearhValue = 0;

            if (month == "Select Month ... ")
            {
                monthValue = 0;
            }
            else if (month == null || month == "")
            {
                monthValue = 0;
            }

            if (year == "Select Year ... ")
            {
                yearhValue = 0;
            }
            else if (year == null || year == "")
            {
                yearhValue = 0;
            }

            //var expenses = from c in _context.Expenses select c;

            var  expenses = _context.Expenses
                        .Where(i => i.IsApproved)
                        .Where(i => i.PerDate.Month == monthValue)
                        .Where(i => i.PerDate.Year == yearhValue);
            //    ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");

            return View(expenses.ToList()); 
        }


        [HttpPost]
        public IActionResult ViewMonthlyExpense(Expense expense, string month = "", string year = "")
        {

            int monthValue = 0;
            int yearhValue = 0;


            if (month != null || month != "")
            {
                if (month == "Select Month ... ")
                {
                    monthValue = 0;
                }
                else if (month == "January")
                {
                    monthValue = 1;
                }
                else if (month == "February")
                {
                    monthValue = 2;
                }
                else if (month == "March")
                {
                    monthValue = 3;
                }
                else if (month == "April")
                {
                    monthValue = 4;
                }
                else if (month == "May")
                {
                    monthValue = 5;
                }
                else if (month == "June")
                {
                    monthValue = 6;
                }
                else if (month == "July")
                {
                    monthValue = 7;
                }
                else if (month == "August")
                {
                    monthValue = 8;
                }
                else if (month == "September")
                {
                    monthValue = 9;
                }
                else if (month == "October")
                {
                    monthValue = 10;
                }
                else if (month == "November")
                {
                    monthValue = 11;
                }
                else if (month == "December")
                {
                    monthValue = 12;
                }
            }
            else if (month == null || month == "")
            {
                monthValue = 0;
            }

            if (year != null || year != "")
            {
                yearhValue = Convert.ToInt32(year.ToString());
            }
            else if (year == "Select Year ... ")
            {
                yearhValue = 0;
            }
            else if (year == null || year == "")
            {
                yearhValue = 0;
            }


            //var expenses = from c in _context.Expenses select c;

            var expenses = _context.Expenses
                        .Where(i => i.IsApproved)
                        .Where(i => i.PerDate.Month == monthValue)
                        .Where(i => i.PerDate.Year == yearhValue);


                ViewBag.Years = GetAllYearList();
                ViewBag.Month = month;
                ViewBag.Year = year;
            //    ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
            ViewData["Years"] = GetAllYearList();
      
            return View(expenses.ToList()); 
        }

        [HttpGet]
        public IActionResult ViewYearlyProfit()
        {
            int year = 0;
            int month = 0;
            ViewBag.Years = GetAllYearList();
            ViewBag.Year = year;
            ViewBag.month = month; 
            //ViewData["GetYear"] = new SelectList(_context.SelectYears, "YrId", "YearName");
            var model = _context.YearlyDataModelViews.ToList();
            return View(model);
        }


        [HttpPost]
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
                    Month = a.Key, 
                    amount = a.Sum(r => r.Amount),
                });

            var expense = _context.Expenses
                .Where(x => x.IsApproved)
                .Where(x => x.PerDate.Year.Equals(year))
                .GroupBy(x => x.PerDate.Month)
                .Select(a => new
                {
                    Month = a.Key, 
                    amount = a.Sum(r => r.Amount),
                });


            var query = (from i in income
                         join e in expense on i.Month equals e.Month
                         select new 
                         {                             
                             month=i.Month,
                             IncomeAmount = i != null ? i.amount : 0,
                             ExpenseAmount = e != null ? e.amount : 0,
                             Profit = i.amount - e.amount, 
                         }).OrderByDescending(c => c.month).ToList(); 

            //OrderBy(x => x.Month)

            List<YearlyDataModelView> data = query.Select(x => new YearlyDataModelView()
            {
                Month = x.month,
                IncomeAmount = x.IncomeAmount,
                ExpenseAmount = x.ExpenseAmount,
                Profit = x.IncomeAmount- x.ExpenseAmount,

            }).ToList();

            //ViewData["Years"] = GetAllYearList();

            ViewBag.Years = GetAllYearList();
            ViewBag.Year = year;

            return View(data);  
        }

        private List<SelectYear> GetYear() 
        {
             List<SelectYear> yearList = _context.SelectYears.ToList();
            return yearList;
        }

        public List<SelectYear> GetAllYearList()
        {
            List<SelectYear> yearList = new List<SelectYear>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM [dbo].[SelectYears]";
            //string query = _context.SelectYears.ToList().ToString();
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
             
            if (reader.HasRows)
            {
                SelectYear yearEmpty = new SelectYear();
                
                yearEmpty.YrId = 0;
                yearEmpty.YearName = "Select Year ... ";
                yearList.Add(yearEmpty);


                while (reader.Read())
                {
                    SelectYear years = new SelectYear();
                    years.YrId = Convert.ToInt32(reader["YrId"].ToString());
                    years.YearName = reader["YearName"].ToString();
                    yearList.Add(years);
                }
                reader.Close();
            }
            connection.Close();
            return yearList;
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
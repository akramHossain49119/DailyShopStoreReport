﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models  
{
    public class YearlyDataModelView
    {
        public int  Id { get; set; } 
        public int Month { get; set; }
        public DateTime Year { get; set; } 
        public double IncomeAmount { get; set; }
        public double ExpenseAmount { get; set; }
        public double Profit { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models  
{
    public class Expense: AmountCalculate
    {
        public Expense()
        {

        }

        [Display(Name = "Expense Name")]
        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Expense Name is required")]
        public string ExpenseName { get; set; } 

    }
}

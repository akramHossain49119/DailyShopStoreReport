using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models  
{
    public class Income : AmountCalculate
    {

        public Income()
        {
            
        }
        
        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Income Name is required")] 
        public string IncomeName { get; set; }
               
    }
}

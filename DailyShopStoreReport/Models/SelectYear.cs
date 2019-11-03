using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 
namespace DailyShopStoreReport.Models
{
    public class SelectYear
    {
        [Key]
        public int YrId { get; set; }
        public string YearName { get; set; }   
    }
}

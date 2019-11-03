using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models  
{
    public class Income
    {
        [Key] 
        public int IncId { get; set; } 

        [Required]
        public string UserId { get; set; }
        public AppUser User { get; set; }

        //public int UUserUId { get; set; } 
        //public virtual UUser UUser { get; set; }  


        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Income Type is required")]
        public string IncomeType { get; set; }

        [Column(TypeName = "money")]
        [Required(ErrorMessage = "Amount is required")]
        [DataType(DataType.Currency, ErrorMessage = "Amount must be numeric")]
        public double IncAmount { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string IncChequeNo { get; set; }

        [Column (TypeName = "varchar(250)")]
        public string IncBankName { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Particular is required")]
        public string IncParticular { get; set; }

        [Column(TypeName = "datetime")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Date format is invalid")]
        public DateTime IncDate { get; set; }

        [Column(TypeName = "bit")]
        public bool IncIsApproved { get; set; }

        public Income()
        {
            IncIsApproved = false;
        }

    }
}

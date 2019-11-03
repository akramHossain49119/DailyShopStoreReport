using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models  
{
    public class Expense
    {
        [Key]  
        public int ExpId { get; set; }  

        [Required]
        public string UserId { get; set; }
        public AppUser User { get; set; }

        [Display(Name = "User Role")]
        public virtual AppRole AppRole { get; set; }
        public int AppRoleId { get; set; } 


        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Expense Type is required")]
        public string ExpenseType { get; set; }

        [Column(TypeName = "money")]
        [Required(ErrorMessage = "Amount is required")]
        [DataType(DataType.Currency, ErrorMessage = "Amount must be numeric")]
        public double ExpAmount { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string ExpChequeNo { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string ExpBankName { get; set; }

        [Column(TypeName = "text")]
        [Required(ErrorMessage = "Particular is required")]
        public string ExpParticular { get; set; }

        [Column(TypeName = "datetime")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Date format is invalid")]
        public DateTime ExpDate { get; set; }

        [Column(TypeName = "bit")]
        public bool ExpIsApproved { get; set; }

        public Expense()
        {
            ExpIsApproved = false;
        }

    }
}

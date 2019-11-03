using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models
{
    public class AmountCalculate
    {

        [Key]
        public int CalId { get; set; } 

        [Required]
        [Display(Name = "User Name")]
        public string UserId { get; set; }
        public AppUser User { get; set; }

        [Display(Name = "User Role")]
        public virtual AppRole AppRole { get; set; }
        public int AppRoleId { get; set; }


        [Column(TypeName = "varchar(20)")]
        [Required(ErrorMessage = "Expense Type is required")]
        public string Type { get; set; }

        [Column(TypeName = "money")]
        [Required(ErrorMessage = "Amount is required")]
        [DataType(DataType.Currency, ErrorMessage = "Amount must be numeric")]
        public double  Amount { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string  ChequeNo { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string BankName { get; set; }

        [Column(TypeName = "text")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Particular is required")]
        public string Particular { get; set; }

        [Column(TypeName = "datetime")]
        [Required(ErrorMessage = "Date is required")]
        [DataType(DataType.Date, ErrorMessage = "Date format is invalid")]
        public DateTime Date { get; set; }

        [Column(TypeName = "bit")]
        public bool IsApproved { get; set; }

        public AmountCalculate()
        {
            IsApproved = false;
        }

    }
}

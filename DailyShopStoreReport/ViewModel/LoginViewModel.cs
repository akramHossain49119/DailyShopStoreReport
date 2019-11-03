using DailyShopStoreReport.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.ViewModel
{
    public class LoginViewModel
    {
        [Key]
        public int ULId { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",  ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [EmailAddress] 
        public string UseName { get; set; }

        public int AppRoleId { get; set; } 
        public virtual AppRole AppRole { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
}

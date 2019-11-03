using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DailyShopStoreReport.Models 
{
    public class UUser: IdentityUser 
    { 
        public UUser() : base() 
        {

        }

        [Required]
        [Display(Name = "User Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
            ErrorMessage = "Invalid email format")]
        public string UEmail { get; set; }
         

        [Display(Name = "User Role")]
        public virtual AppRole AppRole { get; set; }
        public int AppRoleId { get; set; } 


        [Required]
        [Display(Name = "User Subject")]
        public string USubject { get; set; }


        [Display(Name = "User Description")]

        public string UAddress { get; set; } 



    }
}
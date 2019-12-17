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

        [Required(ErrorMessage = "Please provide Email Address.")]       
        [Display(Name = "Email Address")]
        [EmailAddress]
        [RegularExpression(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", ErrorMessage = "Please provide valid email")]
        public string UEmail { get; set; }



        [Required]
        [Display(Name = "User Subject")]
        public string USubject { get; set; }


        [Display(Name = "User Description")]

        public string UAddress { get; set; } 



    }
}
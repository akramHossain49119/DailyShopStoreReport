using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DailyShopStoreReport.Models  
{
    public class AppPermission: IdentityUser<int>
    {
        public AppPermission() : base() 
        {
        }

        [Display(Name = "User Role")]
        public virtual AppRole AppRole { get; set; } 
        public int AppRoleId { get; set; } 


        [Display(Name = "User Menu")]
        public virtual AppMenu AppMenu { get; set; }
        public int AppMenuId { get; set; } 






    }
}
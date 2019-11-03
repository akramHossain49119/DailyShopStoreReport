using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DailyShopStoreReport.Models 
{
    public class AppMenu  : IdentityUser<int>
    {
        public AppMenu() : base() 
        {

        }

        [Display(Name = "User Menu Name")]
        public string UrlName { get; set; }


    }
}
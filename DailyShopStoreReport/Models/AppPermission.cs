using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyShopStoreReport.Models  
{
    public class AppPermission  
    {

        [Key]
        public int ApId { get; set; }  



        //[ForeignKey("NavigationMenu")]
        public Guid? AppMenuId { get; set; }
        public virtual AppMenu AppMenus { get; set; }

    }
}
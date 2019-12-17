using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DailyShopStoreReport.Models 
{
    public class AppMenu
    {

        [Key]
        public int AMId { get; set; }  

        public string Name { get; set; }

        //[ForeignKey("ParentNavigationMenu")]
        public Guid? AppMenuId { get; set; } 
        public virtual AppMenu AppMenus { get; set; } 

        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        [NotMapped]
        public bool Permitted { get; set; }



    }
}
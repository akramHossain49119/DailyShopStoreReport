using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace DailyShopStoreReport.Models 
{
    public class AppUser: IdentityUser<int>
    {
        public AppUser():base()
        {

        }

        public string Name { get; set; }

        
    }
}

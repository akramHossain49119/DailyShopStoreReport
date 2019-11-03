using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.Models 
{
    public class AppRole:IdentityUser<int>
    {
        public AppRole() : base()
        {

        }

        public string Name { get; set; }

    }
}


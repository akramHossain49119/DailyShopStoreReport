using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.ViewModel
{
    public class AppRole
    {
        [Key]
        public int URId { get; set; }
        public string RoleName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.ViewModel 
{
    public class UserRoleViewModel
    {
        [Key]
        public int URId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        public string RoleId { get; set; }
        public bool IsSelected { get; set; }
    }
}

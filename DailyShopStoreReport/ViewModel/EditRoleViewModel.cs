using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DailyShopStoreReport.ViewModel
{
    public class EditRoleViewModel
    {
        [Key]
        public int UEId { get; set; }
        public EditRoleViewModel()
        {
            Users = new List<string>();
        }

        public string Id { get; set; }

        [Required(ErrorMessage = "Role Name is required")]
        public string Name { get; set; } 

        public List<string> Users { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.UserRoles
{
    public class CreateEditUserRoleViewModel
    {
        public string UserId { get; set; }
        public string RoleId { get; set; }



        public bool Success { get; set; }
        public string Result { get; set; }
    }
}

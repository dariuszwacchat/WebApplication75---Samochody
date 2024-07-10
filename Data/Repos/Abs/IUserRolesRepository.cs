using Domain.Models;
using Domain.ViewModels.UserRoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IUserRolesRepository
    {
        Task<List<ApplicationUser>> GetAll ();
        Task<ApplicationUser> Get (string id);
        Task<CreateUserRoleViewModel> Create (CreateUserRoleViewModel model);
        Task<EditUserRoleViewModel> Update (EditUserRoleViewModel model);
        Task<bool> Delete (string id);
    }
}

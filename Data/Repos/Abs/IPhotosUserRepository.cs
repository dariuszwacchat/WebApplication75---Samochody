using Domain.Models;
using Domain.ViewModels.PhotosUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IPhotosUserRepository
    {
        Task<List<PhotoUser>> GetAll ();
        Task<PhotoUser> Get (string id);
        Task<CreatePhotoUserViewModel> Create (CreatePhotoUserViewModel model);
        Task<EditPhotoUserViewModel> Update (EditPhotoUserViewModel model);
        Task<bool> Delete (string id);
    }
}

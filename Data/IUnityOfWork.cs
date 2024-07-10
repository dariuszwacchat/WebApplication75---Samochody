using Data.Repos.Abs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IUnityOfWork
    {
        IPhotosUserRepository PhotosUserRepository { get; set; } 

        Task SaveChangesAsync ();
    }
}

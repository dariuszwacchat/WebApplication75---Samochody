using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.PhotosUser
{
    public class CreateEditPhotoUserViewModel : PropertyBaseViewModel
    {
        public string PhotoUserId { get; set; }
        public byte[] PhotoData { get; set; }
        public string UserId { get; set; }

    }
}

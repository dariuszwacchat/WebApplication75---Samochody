using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoUser
    {
        [Key]
        public string PhotoUserId { get; set; }
        public byte[] PhotoData { get; set; }


        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}

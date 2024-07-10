using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoKupno
    {
        [Key]
        public string PhotoKupnoId { get; set; } 
        public byte[] PhotoData { get; set; }


        public string KupnoId { get; set; }
        public Kupno Kupno { get; set; }
    }
}

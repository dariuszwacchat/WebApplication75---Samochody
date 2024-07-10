using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoRodzajTowaru
    {
        [Key]
        public string PhotoRodzajTowaruId { get; set; }
        public byte[] PhotoData { get; set; }


        public string RodzajTowaruId { get; set; }
        public RodzajTowaru RodzajTowaru { get; set; }
    }
}

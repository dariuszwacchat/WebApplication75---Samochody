using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoTowar
    {
        [Key]
        public string PhotoTowarId { get; set; }
        public byte[] PhotoData { get; set; }


        public string TowarId { get; set; }
        public Towar Towar { get; set; }

    }
}

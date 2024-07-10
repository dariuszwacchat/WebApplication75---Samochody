using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoSprzedaz
    {
        [Key]
        public string PhotoSprzedazId { get; set; }
        public byte[] PhotoData { get; set; }
    }
}

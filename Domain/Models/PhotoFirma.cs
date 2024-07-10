using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PhotoFirma
    {
        [Key]
        public string PhotoFirmaId { get; set; }
        public byte[] PhotoData { get; set; }


        public string FirmaId { get; set; }
        public Firma Firma { get; set; }

    }
}

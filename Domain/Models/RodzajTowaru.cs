using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RodzajTowaru
    {
        [Key] 
        public string RodzajTowaruId { get; set; }
        public string Nazwa { get; set; }



        public List<Kupno> Kupna { get; set; }
        public List<Sprzedaz> Sprzedaze { get; set; }
        public List <Towar> Towary { get; set; }
        public List <PhotoRodzajTowaru> PhotosRodzajTowaru { get; set; }
    }
}

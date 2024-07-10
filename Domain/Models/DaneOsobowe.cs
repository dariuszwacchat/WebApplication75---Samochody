using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class DaneOsobowe
    {
        [Key] 
        public string DaneOsoboweId { get; set; }

        [Required]
        public string Imie { get; set; }
        [Required]
        public string Nazwisko { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataUrodzenia { get; set; }
        public string Pesel { get; set; }
        [Required]
        public string Kraj { get; set; }
        [Required]
        public string Miasto { get; set; }
        [Required]
        public string Powiat { get; set; }
        [Required]
        public string Ulica { get; set; }
        [Required]
        public string NumerUlicy { get; set; }


        [Required]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }



        public List<Firma>? Firma { get; set; }
        public List<Kupno>? Kupna { get; set; }
        public List<Sprzedaz>? Sprzedaze { get; set; } 
    }
}

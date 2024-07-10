using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Kupno
    {
        [Key]
        public string KupnoId { get; set; }


        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double CenaZakupu { get; set; }
        public int Sztuk { get; set; }
        public double Rabat { get; set; }
        public string Kolor { get; set; }
        public double Wysokosc { get; set; }
        public double Szerokosc { get; set; }
        public double Waga { get; set; }
        [DataType(DataType.Date)]
        public DateTime RokProdukcji { get; set; }
        [Required]
        public double Przebieg { get; set; }
        
        [Required]
        [DataType(DataType.Date)]
        public DateTime DataZakupu { get; set; }

        public string? SprzedajacyId { get; set; }
        public DaneOsobowe? Sprzedajacy { get; set; }

        public string? KupujacyId { get; set; }
        public DaneOsobowe? Kupujacy { get; set; }

        public string? RodzajPojazduId { get; set; }
        public RodzajPojazdu? RodzajPojazdu { get; set; }

        public string? MarkaId { get; set; }
        public Marka? Marka { get; set; }

        public List<PhotoKupno>? PhotosKupno { get; set; }
    }
}

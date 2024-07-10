﻿using Domain.Models.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Towar
    {
        [Key]
        public string TowarId { get; set; }
        public string Nazwa { get; set; }
        public string Opis { get; set; }
        public double Cena { get; set; }
        public int Sztuk { get; set; }
        public double Rabat { get; set; }
        public string Kolor { get; set; }
        public double Wysokosc { get; set; }
        public double Szerokosc { get; set; }
        public double Waga { get; set; }
        [DataType(DataType.Date)]
        public DateTime RokProdukcji { get; set; } 
        public double Przebieg { get; set; }
        public RodzajHandlu RodzajHandlu { get; set; }
        public DateTime DataDodania { get; set; }


        public string RodzajTowaruId { get; set; }
        public RodzajTowaru RodzajTowaru { get; set; }

        public string MarkaId { get; set; }
        public Marka Marka { get; set; }


        public List<Kupno> Kupna { get; set; }
        public List<Sprzedaz> Sprzedaze { get; set; }
        public List <PhotoTowar> PhotosTowar { get; set; }
    }
}

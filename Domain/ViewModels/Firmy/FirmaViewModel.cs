using Domain.Models;
using Domain.Models.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Firmy
{
    public class FirmaViewModel : Firma
    {
        public string Imie_DaneOsobowe { get; set; }
        public string Nazwisko_DaneOsobowe { get; set; }
        public string Telefon_DaneOsobowe { get; set; }
        public string Ulica_DaneOsobowe { get; set; }
        public string NumerUlicy_DaneOsobowe { get; set; }
        public string Miejscowosc_DaneOsobowe { get; set; }
        public string Pesel_DaneOsobowe { get; set; }
        public string Kraj_DaneOsobowe { get; set; }
        public string KodPocztowy_DaneOsobowe { get; set; }
        public DateTime DataUrodzenia_DaneOsobowe { get; set; }
        public Plec Plec_DaneOsobowe { get; set; }
        public string Email_DaneOsobowe { get; set; }
        public DateTime DataDodania_DaneOsobowe { get; set; }
        public RodzajTransakcji RodzajTransakcji_DaneOsobowe { get; set; }


        public List <IFormFile> Files { get; set; }
        public bool Success { get; set; }
        public string Result { get; set; }
    }
}

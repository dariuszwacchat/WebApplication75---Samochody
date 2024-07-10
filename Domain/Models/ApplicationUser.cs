﻿using Domain.Models;
using Domain.Models.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ApplicationUser : IdentityUser <string>
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Telefon { get; set; }
        public string Ulica { get; set; }
        public string NumerUlicy { get; set; }
        public string Miejscowosc { get; set; }
        public string Kraj { get; set; }
        public string KodPocztowy { get; set; }
        public DateTime DataUrodzenia { get; set; }
        public Plec Plec { get; set; }
        public bool Newsletter { get; set; }  
        public int IloscZalogowan { get; set; }
        public string DataOstatniegoZalogowania { get; set; }
        public DateTime DataDodania { get; set; }




        public List<PhotoUser>? PhotosUser { get; set; }
        public List<LoggingError>? LoggingErrors { get; set; }
    }
}

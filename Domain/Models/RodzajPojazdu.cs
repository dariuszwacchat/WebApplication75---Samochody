﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class RodzajPojazdu
    {
        [Key] 
        public string RodzajPojazduId { get; set; }
        public string Name { get; set; }


        public List<Kupno>? Kupna { get; set; }
        public List<Sprzedaz>? Sprzedasze { get; set; }

    }
}

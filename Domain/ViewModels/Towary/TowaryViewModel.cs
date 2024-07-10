using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Towary
{
    public class TowaryViewModel : BaseViewModel <Towar>
    {
        public List <Towar> Towary { get; set; }
    }
}

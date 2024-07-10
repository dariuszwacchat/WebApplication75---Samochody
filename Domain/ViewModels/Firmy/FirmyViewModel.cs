using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Firmy
{
    public class FirmyViewModel : BaseViewModel <Firma>
    {
        public List <Firma> Firmy { get; set; }
    }
}

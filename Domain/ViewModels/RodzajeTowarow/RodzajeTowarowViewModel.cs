using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.RodzajeTowarow
{
    public class RodzajeTowarowViewModel : BaseViewModel <RodzajTowaru>
    {
        public List <RodzajTowaru> RodzajeTowarow { get; set; }
    }
}

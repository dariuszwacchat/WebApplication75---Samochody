using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Sprzedaze
{
    public class SprzedazeViewModel : BaseViewModel <Sprzedaz>
    {
        public List <Sprzedaz> Sprzedaze { get; set; }
    }
}

using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.ViewModels.Kupna
{
    public class KupnaViewModel : BaseViewModel <Kupno>
    {
        public List<Kupno> Kupna { get; set; }
    }
}

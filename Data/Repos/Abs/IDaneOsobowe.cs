using Domain.Models;
using Domain.ViewModels.DaneOsobowe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IDaneOsobowe
    {
        Task<List<DaneOsobowe>> GetAll ();
        Task<DaneOsobowe> Get (string id);
        Task<DanaOsobowaViewModel> Create (DanaOsobowaViewModel model);
        Task<DanaOsobowaViewModel> Update (DanaOsobowaViewModel model);
        Task<bool> Delete (string id);
    }
}

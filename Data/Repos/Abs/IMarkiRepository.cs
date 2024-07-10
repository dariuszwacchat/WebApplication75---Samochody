using Domain.Models;
using Domain.ViewModels.Firmy;
using Domain.ViewModels.Marki;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IMarkiRepository
    {
        Task<List<Marka>> GetAll ();
        Task<Marka> Get (string id);
        Task<MarkaViewModel> Create (MarkaViewModel model);
        Task<MarkaViewModel> Update (MarkaViewModel model);
        Task<bool> Delete (string id);
    }
}

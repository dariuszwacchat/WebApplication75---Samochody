using Domain.Models;
using Domain.ViewModels.Firmy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IFirmyRepository
    {
        Task<List<Firma>> GetAll ();
        Task<Firma> Get (string id);
        Task<FirmaViewModel> Create (FirmaViewModel model);
        Task<FirmaViewModel> Update (FirmaViewModel model);
        Task<bool> Delete (string id);
    }
}

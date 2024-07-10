using Domain.Models;
using Domain.ViewModels.Kupna;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IKupnaRepository
    {
        Task<List<Kupno>> GetAll ();
        Task<Kupno> Get (string id);
        Task<KupnoViewModel> Create (KupnoViewModel model);
        Task<KupnoViewModel> Update (KupnoViewModel model);
        Task<bool> Delete (string id);
    }
}

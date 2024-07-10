using Domain.Models;
using Domain.ViewModels.RodzajeTowarow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos.Abs
{
    public interface IRodzajeTowarowRepository
    {
        Task<List<RodzajTowaru>> GetAll ();
        Task<RodzajTowaru> Get (string id);
        Task<RodzajTowaruViewModel> Create (RodzajTowaruViewModel model);
        Task<RodzajTowaruViewModel> Update (RodzajTowaruViewModel model);
        Task<bool> Delete (string id);
    }
}

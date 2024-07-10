using Data.Repos;
using Data.Repos.Abs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Data
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly ApplicationDbContext _context;

        public IPhotosUserRepository PhotosUserRepository { get; set; }

        public UnityOfWork (ApplicationDbContext context)
        {
            _context = context;

            PhotosUserRepository = new PhotosUserRepository (_context);
        }

        public async Task SaveChangesAsync ()
        {
            await _context.SaveChangesAsync ();
        } 
    }
}

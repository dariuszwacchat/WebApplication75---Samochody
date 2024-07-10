﻿using Data.Repos.Abs;
using Domain.Models;
using Domain.ViewModels.RodzajeTowarow;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repos
{
    public class RodzajeTowarowRepository : IRodzajeTowarowRepository
    {
        private readonly ApplicationDbContext _context;
        public RodzajeTowarowRepository (ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<RodzajTowaru>> GetAll ()
        {
            return await _context.RodzajeTowarow.ToListAsync();
        }

        public async Task<RodzajTowaru> Get (string id)
        {
            return await _context.RodzajeTowarow.FirstOrDefaultAsync(f => f.RodzajTowaruId == id);
        }


        public async Task<RodzajTowaruViewModel> Create (RodzajTowaruViewModel model)
        {
            if (model != null)
            {
                try
                {
                    RodzajTowaru rodzajTowaru = new RodzajTowaru ()
                    {
                        RodzajTowaruId = Guid.NewGuid ().ToString (),
                        Nazwa = model.Nazwa
                    };

                    _context.RodzajeTowarow.Add (rodzajTowaru);
                    await _context.SaveChangesAsync();


                    // Dodanie zdjęcia
                    await CreateNewPhoto (model.Files, rodzajTowaru.RodzajTowaruId);


                    model.Success = true; 

                }
                catch (Exception ex)
                {
                    model.Result = "Catch exception.";
                }
            }
            else
            {
                model.Result = "Model is null.";
            }
            return model;
        }



        public async Task<RodzajTowaruViewModel> Update (RodzajTowaruViewModel model)
        {
            if (model != null)
            {
                try
                {
                    var rodzajTowaru = await _context.RodzajeTowarow.FirstOrDefaultAsync (f=> f.RodzajTowaruId == model.RodzajTowaruId);
                    if (rodzajTowaru != null)
                    {
                        rodzajTowaru.Nazwa = model.Nazwa; 

                        _context.Entry(rodzajTowaru).State = EntityState.Modified;
                        await _context.SaveChangesAsync();


                        // Dodanie zdjęcia
                        await CreateNewPhoto(model.Files, rodzajTowaru.RodzajTowaruId);


                        model.Success = true;
                    }
                    else
                    {
                        model.Result = "RodzajTowaru is null.";
                    }
                }
                catch (Exception ex)
                {
                    model.Result = "Catch exception.";
                }
            }
            else
            {
                model.Result = "Model is null.";
            }
            return model;
        }



        public async Task<bool> Delete (string id)
        {
            bool deleteResult = false;
            try
            {
                var rodzajTowaru = await _context.RodzajeTowarow.FirstOrDefaultAsync (f=> f.RodzajTowaruId == id);
                if (rodzajTowaru != null)
                {
                    // Usuniecie zdjęć 
                    var photosRodzajTowaru = await _context.PhotosRodzajTowaru.Where (w=> w.RodzajTowaruId == rodzajTowaru.RodzajTowaruId).ToListAsync ();
                    foreach (var photoRodzajTowaru in photosRodzajTowaru)
                        _context.PhotosRodzajTowaru.Remove (photoRodzajTowaru);
                     
                    _context.RodzajeTowarow.Remove (rodzajTowaru);
                    await _context.SaveChangesAsync();
                    deleteResult = true;
                }
                else
                {
                }
            }
            catch (Exception ex)
            {
            }
            return deleteResult;
        }



        private async Task CreateNewPhoto (List<IFormFile> files, string rodzajTowaruId)
        {
            try
            {
                if (files != null && files.Count > 0 && !string.IsNullOrEmpty(rodzajTowaruId))
                {
                    foreach (var file in files)
                    {
                        if (file.Length > 0)
                        {
                            byte [] photoData;
                            using (var stream = new MemoryStream())
                            {
                                file.CopyTo(stream);
                                photoData = stream.ToArray();

                                PhotoRodzajTowaru photoRodzajTowaru = new PhotoRodzajTowaru ()
                                {
                                    PhotoRodzajTowaruId = Guid.NewGuid ().ToString (),
                                    PhotoData = photoData,
                                    RodzajTowaruId = rodzajTowaruId
                                };
                                _context.PhotosRodzajTowaru.Add(photoRodzajTowaru);
                                await _context.SaveChangesAsync();
                            }
                        }
                    }
                }
            }
            catch { }
        }




    }
}

using Data;
using Data.Services;
using Domain.Models;
using Domain.Models.Enum;
using Domain.ViewModels.Firmy;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class FirmyController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;

        public FirmyController (IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index (FirmyViewModel model)
        {
            NI.Navigation = Navigation.RolesIndex;
            var firmy = await _unityOfWork.FirmyRepository.GetAll();
            return View(new FirmyViewModel()
            {
                Firmy = firmy,
                Paginator = Paginator<Firma>.CreateAsync(firmy, model.PageIndex, model.PageSize),
                PageIndex = model.PageIndex,
                PageSize = model.PageSize,
                Start = model.Start,
                End = model.End,
                q = model.q,
                SortowanieOption = model.SortowanieOption
            });
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index (string s, FirmyViewModel model)
        {
            NI.Navigation = Navigation.RolesIndex;
            var firmy = await _unityOfWork.FirmyRepository.GetAll();

            // Wyszukiwanie
            if (!string.IsNullOrEmpty(model.q))
                firmy = firmy.Where(w => w.NazwaFirmy.Contains(model.q, StringComparison.OrdinalIgnoreCase)).ToList();


            // Sortowanie 
            switch (model.SortowanieOption)
            {
                case "Nazwa A-Z":
                    firmy = firmy.OrderBy(o => o.NazwaFirmy).ToList();
                    break;

                case "Nazwa Z-A":
                    firmy = firmy.OrderByDescending(o => o.NazwaFirmy).ToList();
                    break;
            }

            model.Firmy = firmy;
            model.Paginator = Paginator<Firma>.CreateAsync(firmy, model.PageIndex, model.PageSize);
            return View(model);
        }



        [HttpGet]
        public IActionResult Create ()
        {
            NI.Navigation = Navigation.FirmyCreate;
            return View(new FirmaViewModel() { Result = "" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (FirmaViewModel model)
        {
            NI.Navigation = Navigation.FirmyCreate;
            if (ModelState.IsValid)
            {
                if (!(await _unityOfWork.FirmyRepository.Create(model)).Success)
                    return RedirectToAction("Index", "Firmy");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Edit (string firmaId)
        {
            NI.Navigation = Navigation.FirmyEdit;

            if (string.IsNullOrEmpty(firmaId))
                return View("NotFound");

            var firma = await _unityOfWork.FirmyRepository.Get (firmaId);

            if (firma == null)
                return View("NotFound");

            return View(new FirmaViewModel()
            {
                FirmaId = firma.FirmaId,
                Kraj = firma.Kraj,
                Miasto = firma.Miasto,
                NazwaFirmy = firma.NazwaFirmy,
                NIP = firma.NIP,
                Ulica = firma.Ulica,
                NumerUlicy = firma.NumerUlicy,
                Powiat = firma.Powiat,
                Regon = firma.Regon,
                WlascicielId = firma.WlascicielId
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (FirmaViewModel model)
        {
            NI.Navigation = Navigation.FirmyEdit;
            if (string.IsNullOrEmpty(model.FirmaId))
                return View("NotFound");

            if (ModelState.IsValid)
            {
                if (!(await _unityOfWork.FirmyRepository.Update(model)).Success)
                    return RedirectToAction("Index", "Firmy");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Delete (string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("NotFound");

            var firma = await _unityOfWork.FirmyRepository.Get (id);

            if (firma == null)
                return View("NotFound");

            return View(firma);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("NotFound");

            if (await _unityOfWork.FirmyRepository.Delete(id))
                return RedirectToAction("Index", "Firmy");

            return View("NotFound");
        }
    }
}

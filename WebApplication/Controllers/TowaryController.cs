﻿using Data;
using Data.Services;
using Domain.Models;
using Domain.Models.Enum;
using Domain.ViewModels.Towary;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Controllers
{
    public class TowaryController : Controller
    {
        private readonly IUnityOfWork _unityOfWork;

        public TowaryController (IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Index (TowaryViewModel model)
        {
            NI.Navigation = Navigation.RolesIndex;
            var towary = await _unityOfWork.TowaryRepository.GetAll();
            return View(new TowaryViewModel()
            {
                Towary = towary,
                Paginator = Paginator<Towar>.CreateAsync(towary, model.PageIndex, model.PageSize),
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
        public async Task<IActionResult> Index (string s, TowaryViewModel model)
        {
            NI.Navigation = Navigation.RolesIndex;
            var towary = await _unityOfWork.TowaryRepository.GetAll();

            // Wyszukiwanie
            if (!string.IsNullOrEmpty(model.q))
                towary = towary.Where(w => w.Nazwa.Contains(model.q, StringComparison.OrdinalIgnoreCase)).ToList();


            // Sortowanie 
            switch (model.SortowanieOption)
            {
                case "Nazwa A-Z":
                    towary = towary.OrderBy(o => o.Nazwa).ToList();
                    break;

                case "Nazwa Z-A":
                    towary = towary.OrderByDescending(o => o.Nazwa).ToList();
                    break;
            }

            model.Towary = towary;
            model.Paginator = Paginator<Towar>.CreateAsync(towary, model.PageIndex, model.PageSize);
            return View(model);
        }



        [HttpGet]
        public IActionResult Create ()
        {
            NI.Navigation = Navigation.RolesCreate;
            return View(new TowarViewModel () { Result = "" });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create (TowarViewModel model)
        {
            NI.Navigation = Navigation.RolesCreate;
            if (ModelState.IsValid)
            {
                if (!(await _unityOfWork.TowaryRepository.Create(model)).Success)
                    return RedirectToAction("Index", "Towary");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Edit (string towarId)
        {
            NI.Navigation = Navigation.RolesEdit;

            if (string.IsNullOrEmpty(towarId))
                return View("NotFound");

            var towar = await _unityOfWork.TowaryRepository.Get (towarId);

            if (towar == null)
                return View("NotFound");

            return View(new TowarViewModel()
            {
                TowarId = towar.TowarId,
                Cena = towar.Cena,
                Kolor = towar.Kolor,
                Nazwa = towar.Nazwa,
                Opis = towar.Opis,
                Przebieg = towar.Przebieg,
                Rabat = towar.Rabat,
                Szerokosc = towar.Szerokosc,
                Sztuk = towar.Sztuk,
                Waga = towar.Waga,
                Wysokosc = towar.Wysokosc,
                RokProdukcji = towar.RokProdukcji,
                RodzajHandlu = towar.RodzajHandlu,
                MarkaId = towar.MarkaId,
                RodzajTowaruId = towar.RodzajTowaruId,
                DataDodania = towar.DataDodania
            });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit (TowarViewModel model)
        {
            NI.Navigation = Navigation.RolesEdit;
            if (string.IsNullOrEmpty(model.TowarId))
                return View("NotFound");

            if (ModelState.IsValid)
            {
                if (!(await _unityOfWork.TowaryRepository.Update(model)).Success)
                    return RedirectToAction("Index", "Towary");
            }

            return View(model);
        }


        [HttpGet]
        public async Task<IActionResult> Delete (string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("NotFound");

            var role = await _unityOfWork.TowaryRepository.Get (id);

            if (role == null)
                return View("NotFound");

            return View(role);
        }


        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed (string id)
        {
            if (string.IsNullOrEmpty(id))
                return View("NotFound");

            if (await _unityOfWork.TowaryRepository.Delete(id))
                return RedirectToAction("Index", "Roles");

            return View("NotFound");
        }

    }
}

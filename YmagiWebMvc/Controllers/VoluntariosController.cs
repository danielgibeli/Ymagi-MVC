using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Models;
using YmagiWebMvc.Services;
using YmagiWebMvc.Models.ViewModels;
using YmagiWebMvc.Services.Exceptions;

namespace YmagiWebMvc.Controllers
{
    public class VoluntariosController : Controller
    {
        private readonly VoluntariosService _voluntariosService;
        private readonly OscService _oscService;

        public VoluntariosController(VoluntariosService voluntariosService, OscService oscService)
        {
            _voluntariosService = voluntariosService;
            _oscService = oscService;
        }

        public IActionResult Index()
        {
            var list = _voluntariosService.FindAll();
            return View(list);
        }

        public IActionResult Cadastro()
        {
            var oscs = _oscService.FindAll();
            var viewModel = new OscFormViewModel { Oscs = oscs };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Cadastro(Voluntario voluntario)
        {
            _voluntariosService.Insert(voluntario);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _voluntariosService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _voluntariosService.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _voluntariosService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _voluntariosService.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            List<Osc> osc = _oscService.FindAll();
            OscFormViewModel viewModel = new OscFormViewModel { Voluntario = obj, Oscs = osc };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Voluntario voluntario)
        {
            if (id != voluntario.Id)
            {
                return BadRequest();
            }
            try
            {
                _voluntariosService.Update(voluntario);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
        }
    }
}
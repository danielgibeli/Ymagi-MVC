using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Models;
using YmagiWebMvc.Services;
using YmagiWebMvc.Models.ViewModels;
using YmagiWebMvc.Services.Exceptions;
using System.Diagnostics;
using System.Threading.Tasks;

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

        public async Task<IActionResult> Index()
        {
            var list = await _voluntariosService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Cadastro()
        {
            var oscs = await _oscService.FindAllAsync();
            var viewModel = new OscFormViewModel { Oscs = oscs };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Cadastro(Voluntario voluntario)
        {
            if (!ModelState.IsValid)
            {
                var osc = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Voluntario = voluntario, Oscs = osc };
                return View(viewModel);
            }                                                                                                                                           

            await _voluntariosService.InsertAsync(voluntario);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _voluntariosService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            await _voluntariosService.RemoveAsync(id);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _voluntariosService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _voluntariosService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Osc> osc = await _oscService.FindAllAsync();
            OscFormViewModel viewModel = new OscFormViewModel { Voluntario = obj, Oscs = osc };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Voluntario voluntario)
        {
            if (!ModelState.IsValid)
            {
                var osc = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Voluntario = voluntario, Oscs = osc };
                return View(viewModel);
            }

            if (id != voluntario.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde!" });
            }
            try
            {
                await _voluntariosService.UpdateAsync(voluntario);
                return RedirectToAction(nameof(Index));
            }
            catch (ApplicationException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message });
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
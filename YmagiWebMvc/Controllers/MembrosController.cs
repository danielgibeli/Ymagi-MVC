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
    public class MembrosController : Controller
    {
        private readonly MembrosService _membrosService;
        private readonly OscService _oscService;

        public MembrosController(MembrosService membrosService, OscService oscService)
        {
            _membrosService = membrosService;
            _oscService = oscService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _membrosService.FindAllAsync();
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
        public async Task<IActionResult> Cadastro(Membro membro)
        {
            if (!ModelState.IsValid)
            {
                var osc = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Membro = membro, Oscs = osc };
                return View(viewModel);
            }                                                                                                                                           

            await _membrosService.InsertAsync(membro);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _membrosService.FindByIdAsync(id.Value);
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
            try
            {
                await _membrosService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {
                return RedirectToAction(nameof(Error), new { message = e.Message});
            }
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _membrosService.FindByIdAsync(id.Value);
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

            var obj = await _membrosService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Osc> osc = await _oscService.FindAllAsync();
            OscFormViewModel viewModel = new OscFormViewModel { Membro = obj, Oscs = osc };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Membro membro)
        {
            if (!ModelState.IsValid)
            {
                var osc = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Membro = membro, Oscs = osc };
                return View(viewModel);
            }

            if (id != membro.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde!" });
            }
            try
            {
                await _membrosService.UpdateAsync(membro);
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
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
        private readonly MembroService _membroService;
        private readonly OscService _oscService;

        public MembrosController(MembroService membroService, OscService oscService)
        {
            _membroService = membroService;
            _oscService = oscService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _membroService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var oscs = await _oscService.FindAllAsync();
            var viewModel = new OscFormViewModel { Oscs = oscs };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Membro membro)
        {
            if (!ModelState.IsValid)
            {
                var oscs = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Membro = membro, Oscs = oscs };
                return View(viewModel);
            }                                                                                                                                           

            await _membroService.InsertAsync(membro);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não fornecido!" });
            }

            var obj = await _membroService.FindByIdAsync(id.Value);
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
                await _membroService.RemoveAsync(id);
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

            var obj = await _membroService.FindByIdAsync(id.Value);
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

            var obj = await _membroService.FindByIdAsync(id.Value);
            if (obj == null)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não encontrado!" });
            }

            List<Osc> oscs = await _oscService.FindAllAsync();
            OscFormViewModel viewModel = new OscFormViewModel { Membro = obj, Oscs = oscs };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Membro membro)
        {
            if (!ModelState.IsValid)
            {
                var oscs = await _oscService.FindAllAsync();
                var viewModel = new OscFormViewModel { Membro = membro, Oscs = oscs };
                return View(viewModel);
            }

            if (id != membro.Id)
            {
                return RedirectToAction(nameof(Error), new { message = "Id não corresponde!" });
            }
            try
            {
                await _membroService.UpdateAsync(membro);
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
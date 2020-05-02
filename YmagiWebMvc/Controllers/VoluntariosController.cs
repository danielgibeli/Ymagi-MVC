                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Models;
using YmagiWebMvc.Services;
using YmagiWebMvc.Models.ViewModels;

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
            if (obj == null )
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
    }
}
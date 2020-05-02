                                                                    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Models;
using YmagiWebMvc.Services;

namespace YmagiWebMvc.Controllers
{
    public class VoluntariosController : Controller
    {
        private readonly VoluntariosService _voluntariosService;

        public VoluntariosController(VoluntariosService voluntariosService)
        {
            _voluntariosService = voluntariosService;
        }

        public IActionResult Index()
        {
            var list = _voluntariosService.FindAll();
            return View(list);
        }

        public IActionResult Cadastro()
        {
            return View();
        }
                                
        [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Cadastro(Voluntario voluntario)
        {
            _voluntariosService.Insert(voluntario);
            return RedirectToAction(nameof(Index)); 
        }
    }
}
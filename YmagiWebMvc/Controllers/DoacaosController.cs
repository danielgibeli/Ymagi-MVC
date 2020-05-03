using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YmagiWebMvc.Services;

namespace YmagiWebMvc.Controllers
{
    public class DoacaosController : Controller
    {
        private readonly DoacaosService doacaosService;

        public DoacaosController(DoacaosService doacaosService)
        {
            this.doacaosService = doacaosService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await doacaosService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public IActionResult BuscaGrupo()
        {
            return View();
        }
    }
}
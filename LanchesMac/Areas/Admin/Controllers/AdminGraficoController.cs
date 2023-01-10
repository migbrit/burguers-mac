using LanchesMac.Areas.Admin.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficosVendaService _graficosVendaService;
        public AdminGraficoController(GraficosVendaService graficosVendaService)
        {
            _graficosVendaService = graficosVendaService;
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficosVendaService.GetVendasLanche(dias);
            return Json(lanchesVendasTotais);
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }
    }
}

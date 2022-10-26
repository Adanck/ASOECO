using Asoeco.Models;
using Asoeco.Services.AsociadosService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asoeco.Controllers
{
    public class AsociadosController : Controller
    {
        private readonly ILogger<AsociadosController> _logger;
        private IAsociadosService asociadosService;

        public AsociadosController(ILogger<AsociadosController> logger)
        {
            _logger = logger;
            asociadosService = new AsociadosService();
        }

        public IActionResult Index()
        {
            var model = this.asociadosService.getAssociates();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
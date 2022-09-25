using Asoeco.Models;
using Asoeco.Services.HomeService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Asoeco.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHomeService homeService;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            homeService = new HomeService();
        }

        public IActionResult Index()
        {
            var model = this.homeService.getHome();
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
using Microsoft.AspNetCore.Mvc;
using RastgeleSayiDependencyInjection.Models;
using RastgeleSayiDependencyInjection.Services;
using System.Diagnostics;

namespace RastgeleSayiDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RastgeleBirSayi _rastgeleBirSayi;

        public HomeController(ILogger<HomeController> logger, RastgeleBirSayi rastgeleBirSayi)
        {
            _logger = logger;
            _rastgeleBirSayi = rastgeleBirSayi;
        }

        public IActionResult Index([FromServices] RastgeleBirSayi rastgeleBirSayi)
        {
            RastgeleBirSayi rbs = new RastgeleBirSayi();  // MANUEL
            ViewBag.RastgeleSayi = rbs.Deger;

            ViewBag.RastgeleSayiHomeEnjekte = _rastgeleBirSayi.Deger;  // DI
             
            ViewBag.RastgeleSayiActionEnjekte = rastgeleBirSayi.Deger; // Controller Enj.

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
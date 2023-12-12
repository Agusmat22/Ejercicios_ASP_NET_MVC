using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebIntentoPresentacion.Models;
using WebIntentoPresentacion.Models.Interfaces;

namespace WebIntentoPresentacion.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGenerador _proyectos;

        public HomeController(ILogger<HomeController> logger, IGenerador proyectos)
        {
            _logger = logger;
            this._proyectos = proyectos;
        }

        public IActionResult Index()
        {
            List<Proyecto> proyectos = this._proyectos.Generador();
            return View(proyectos);
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

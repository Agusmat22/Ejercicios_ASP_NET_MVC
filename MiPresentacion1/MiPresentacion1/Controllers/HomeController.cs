using Microsoft.AspNetCore.Mvc;
using MiPresentacion1.Models;
using MiPresentacion1.Models.Interfaces;
using MiPresentacion1.Models.Servicios;
using System.Diagnostics;

namespace MiPresentacion1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositorio _repositorios;

        public HomeController(ILogger<HomeController> logger, IRepositorio repositorios)
        {
            _logger = logger;
            this._repositorios = repositorios;
        }

        public IActionResult Index()
        {
            IEnumerable<Proyecto> proyectos = _repositorios.ObtenerProyectos().Take(2).ToList();

            return View(proyectos);
        }

        public IActionResult AllProject()
        {
            _logger.LogInformation("Se ejecuto el logger");

            IEnumerable<Proyecto> proyectos = _repositorios.ObtenerProyectos();

            return View(proyectos); 
        
        }
        [HttpGet]
        public IActionResult Contacto() 
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Contacto(ContactoViewModel contacto)
        {
            return RedirectToAction("Gracias");
        }

        [HttpGet]
        public IActionResult Gracias()
        {
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

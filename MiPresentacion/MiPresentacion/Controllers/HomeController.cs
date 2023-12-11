using Microsoft.AspNetCore.Mvc;
using MiPresentacion.Models;
using MiPresentacion.Models.Interfaces;
using System.Diagnostics;

namespace MiPresentacion.Controllers
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
            //Solo guardo dos proyectos
            List<ProyectoDTO> proyectos = this._repositorios.ObtenerProyectos().Take(1).ToList();

           
            var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
            return View(modelo);
        }

        public IActionResult Prueba()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TodosProyectos()
        {
            var proyectos = this._repositorios.ObtenerProyectos().Take(1).ToList();

            return View(proyectos);
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

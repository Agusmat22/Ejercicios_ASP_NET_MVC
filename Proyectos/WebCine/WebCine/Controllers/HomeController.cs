using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebCine.Models;
using WebCine.Models.Interfaces;

namespace WebCine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICartel _carteles;

        public HomeController(ILogger<HomeController> logger, ICartel carteles)
        {
            _logger = logger;
            this._carteles = carteles;
        }

        public IActionResult Index()
        {
            List<Cartel> cartelera = this._carteles.GeneradorCarteles();
            ViewBag.FechaExposicion = new DateTime(2023, 12, 01);
            ViewBag.Tipo = "Pelicula";
            ViewBag.TituloCartelera = "PELICULAS AGREGADAS";

            return View(cartelera);
        }

        public IActionResult Peliculas() 
        {
            List<Cartel> cartelera = this._carteles.GeneradorCarteles();
            ViewBag.Tipo = "Pelicula";
            ViewBag.TituloCartelera = "LISTA DE PELICULAS";
            return View(cartelera);
        }

        public IActionResult Series()
        {
            List<Cartel> cartelera = this._carteles.GeneradorCarteles();
            ViewBag.Tipo = "Serie";
            ViewBag.TituloCartelera = "LISTA DE SERIES";
            return View(cartelera);
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

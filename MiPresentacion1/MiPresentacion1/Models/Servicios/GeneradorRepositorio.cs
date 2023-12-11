using MiPresentacion1.Models.Interfaces;

namespace MiPresentacion1.Models.Servicios
{
    public class GeneradorRepositorio : IRepositorio
    {
        public IEnumerable<Proyecto> ObtenerProyectos()
        {

            //retorno una lista de protecto que los creo antes de enviarlos
            return new List<Proyecto> {

                new Proyecto()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/AMAZON.jpg"
                },

                new Proyecto()
                {
                    Titulo = "Google",
                    Descripcion = "Pagina donde se busca todo",
                    Link = "https://google.com",
                    ImagenURL = "/imagenes/GOOGLE.jpeg"
                },

                new Proyecto()
                {
                    Titulo = "Steam",
                    Descripcion = "Tienda online para realizar compras de videojuegos",
                    Link = "https://store.steampowered.com/",
                    ImagenURL = "/imagenes/STEAM.jpg"
                }

            };
        }
    }

}

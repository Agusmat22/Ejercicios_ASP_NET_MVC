using MiPresentacion.Models.Interfaces;

namespace MiPresentacion.Models.Servicios
{
    public class RepositorioProyectos : IRepositorio
    {
        public List<ProyectoDTO> ObtenerProyectos()
        {
            //retorno una lista de protecto que los creo antes de enviarlos
            return new List<ProyectoDTO> {

                new ProyectoDTO()
                {
                    Titulo = "Amazon",
                    Descripcion = "E-Commerce realizado en ASP .NET",
                    Link = "https://amazon.com",
                    ImagenURL = "/imagenes/AMAZON.jpg"
                },

                new ProyectoDTO()
                {
                    Titulo = "Google",
                    Descripcion = "Pagina donde se busca todo",
                    Link = "https://google.com",
                    ImagenURL = "/imagenes/GOOGLE.jpeg"
                },

                new ProyectoDTO()
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

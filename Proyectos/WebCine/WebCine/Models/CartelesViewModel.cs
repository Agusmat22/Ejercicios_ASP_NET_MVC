using WebCine.Models.Interfaces;

namespace WebCine.Models
{
    public class CartelesViewModel : ICartel
    {
        public List<Cartel> GeneradorCarteles()
        {
            return new List<Cartel>()
            {
                new Cartel()
                {
                    Titulo = "Megalodon 2",
                    Genero = "Suspenso",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/proximamente/AGUAS-SINIESTRAS",
                    ImagenURL = "https://es.web.img3.acsta.net/pictures/18/07/30/19/02/3253561.jpg",
                    FechaEstreno = new DateTime(2023,12,15)

                },
                new Cartel()
                {
                    Titulo = "Aquaman y el Reino perdido",
                    Genero = "Accion",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/pelicula/AQUAMAN-Y-EL-REINO-PERDIDO",
                    ImagenURL = "https://es.web.img3.acsta.net/pictures/23/09/20/11/47/5660137.jpg",
                    FechaEstreno = new DateTime(2023,12,08)

                },
                new Cartel()
                {
                    Titulo = "Elijo creer",
                    Genero = "Aventura",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/pelicula/ELIJO-CREER",
                    ImagenURL = "https://radiorafaela.com.ar/galeria/fotos/2023/12/03/l_1701645298.webp",
                    FechaEstreno = new DateTime(2023,12,01)

                },
                new Cartel()
                {
                    Titulo = "Muchachos",
                    Genero = "Aventura",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/pelicula/MUCHACHOS",
                    ImagenURL = "https://circuloitaliano.ar/wp-content/uploads/2023/12/6-GZHc59v_720x0__1.jpg",
                    FechaEstreno = new DateTime(2022,10,25)

                },
                new Cartel()
                {
                    Titulo = "Trolls 3",
                    Genero = "Dibujitos",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/pelicula/TROLLS-3-SE-ARMO-LA-BANDA",
                    ImagenURL = "https://es.web.img3.acsta.net/pictures/23/03/29/09/06/4820330.jpg",
                    FechaEstreno = new DateTime(2022,10,25)

                },
                new Cartel()
                {
                    Titulo = "GRI!@#",
                    Genero = "Terror",
                    Tipo = "Pelicula",
                    LinkPelicula = "https://www.cinemarkhoyts.com.ar/proximamente/GRI!@#:-UN-SINIESTRO-CUENTO-DE-NAVIDAD",
                    ImagenURL = "https://static.cinepolis.com.ar/posters/2061/w500/un-siniestro-cuento-de-navidad-poster-okjpg",
                    FechaEstreno = new DateTime(2022,10,25)

                },
                new Cartel()
                {
                    Titulo = "El Encargado",
                    Genero = "Suspenso",
                    Tipo = "Serie",
                    LinkPelicula = "https://www.starplus.com/es-419/series/el-encargado/a897EzMg7taw",
                    ImagenURL = "https://pics.filmaffinity.com/El_encargado_Serie_de_TV-467125987-large.jpg",
                    FechaEstreno = new DateTime(2023,12,10)

                },
                new Cartel()
                {
                    Titulo = "Casa de papel",
                    Genero = "Accion",
                    Tipo = "Serie",
                    LinkPelicula = "https://www.netflix.com/ar/title/80192098",
                    ImagenURL = "https://phantom-marca.unidadeditorial.es/44a766686a0de311721667222b654485/resize/828/f/jpg/assets/multimedia/imagenes/2021/09/02/16305820546830.jpg",
                    FechaEstreno = new DateTime(2023,12,08)

                },
                new Cartel()
                {
                    Titulo = "You",
                    Genero = "Suspenso",
                    Tipo = "Serie",
                    LinkPelicula = "https://www.netflix.com/ar/title/80211991",
                    ImagenURL = "https://es.web.img3.acsta.net/pictures/18/12/31/02/49/2373131.jpg",
                    FechaEstreno = new DateTime(2023,12,05)

                }



            };
        }
    }
}

using WebIntentoPresentacion.Models.Interfaces;

namespace WebIntentoPresentacion.Models
{
    public class GeneradorProyecto : IGenerador
    {
        public List<Proyecto> Generador()
        {
            return new List<Proyecto>()
            {
                new Proyecto()
                {
                    Titulo = "Gestor Afiliados",
                    Tecnologias = "C# | .NET | WINFORMS",
                    ImagenURL = "/imagenes/fotos_proyectos/gestorAfiliados.png",
                    RepositorioURL = "https://github.com/Agusmat22/Gestor_Afiliados_V-2.git"
                },

                new Proyecto()
                {
                    Titulo = "Centro Medico",
                    Tecnologias = "C# | .NET | WINFORMS | SQL Server",
                    ImagenURL = "/imagenes/fotos_proyectos/centro_medico.png",
                    RepositorioURL = "https://github.com/Agusmat22/TP_INTEGRADOR_N2_LABO_II.git"
                },

                new Proyecto()
                {
                    Titulo = "War of Space",
                    Tecnologias = "PYTHON | SQLITE",
                    ImagenURL = "/imagenes/fotos_proyectos/juego_python.png",
                    RepositorioURL = "https://github.com/Agusmat22/WarOfSpace.git"
                }

            };
        }
    }
}

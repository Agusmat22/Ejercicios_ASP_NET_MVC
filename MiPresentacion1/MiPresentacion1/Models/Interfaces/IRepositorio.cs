using MiPresentacion1.Models.Servicios;
using System.Collections;

namespace MiPresentacion1.Models.Interfaces
{
    public interface IRepositorio
    {
        public IEnumerable<Proyecto> ObtenerProyectos();
    }
}

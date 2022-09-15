using BugTracker.DataAccessLayer;
using BugTracker.Entities;

namespace BugTracker.BusinessLayer
{
    internal class EstadoService: IEstadoService
    {
        public List<Estado> ObtenerEstados()
        {
            EstadoDao dao = new EstadoDao();
            List<Estado> resultado = dao.GetEstados();
            return resultado;
        }
    }
}
using BugTracker.DataAccessLayer;
using BugTracker.Entities;

namespace BugTracker.BusinessLayer
{
    internal class EstadoService2 : IEstadoService
    {
        public List<Estado> ObtenerEstados()
        {
            
            return new List<Estado>()
            {
                new Estado(){
                    IdEstado = 1,
                    Nombre = "Inicio"
                }
            };
        }
    }
}
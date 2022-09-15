using BugTracker.Entities;

namespace BugTracker.BusinessLayer
{
    internal interface IEstadoService
    {
        List<Estado> ObtenerEstados();
    }
}
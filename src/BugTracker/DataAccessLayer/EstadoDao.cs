using BugTracker.Entities;
using System.Data;

namespace BugTracker.DataAccessLayer
{
    internal class EstadoDao
    {
        public EstadoDao()
        {
        }

        internal List<Estado> GetEstados()
        {
            List<Estado> listaEstados = new List<Estado>();

            DataTable dt = DataManager.GetInstance().ConsultaSQL("Select * from Estados");

            foreach(DataRow estado in dt.Rows)
            {
                listaEstados.Add(MappingEstado(estado));
            }

            return listaEstados;
        }

        private Estado MappingEstado(DataRow estado)
        {
            
            Estado nuevoEstado = new Estado();
            nuevoEstado.IdEstado = Convert.ToInt32(estado["id_estado"].ToString());
            nuevoEstado.Nombre = estado["nombre"].ToString();
            return nuevoEstado;
        }
    }
}
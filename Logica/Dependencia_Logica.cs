using Data;
using Datos;
using System.Data;

namespace Logica
{
    public class Dependencia_Logica
    {
        private Dependecias_Datos datosDependencia = new Dependecias_Datos();


        public DataTable ObtenerTodasLasDependencias()
        {
            return datosDependencia.ObtenerTodasLasDependencias();
        }


        public DataTable ObtenerDependenciaPorId(string idDependencia)
        {
            return datosDependencia.ObtenerDependenciaPorId(idDependencia);
        }

    
        public int AgregarDependencia(string idDependencia, string nombreDependencia)
        {
            return datosDependencia.AgregarDependencia(idDependencia, nombreDependencia);
        }

  
        public int EditarDependencia(string idDependencia, string nombreDependencia)
        {
            return datosDependencia.EditarDependencia(idDependencia, nombreDependencia);
        }

        public int EliminarDependencia(string idDependencia)
        {
            return datosDependencia.EliminarDependencia(idDependencia);
        }

        public DataTable FiltrarDependencias(string idDependencia = null, string nombreDependencia = null)
        {
            return datosDependencia.FiltrarDependencias(idDependencia, nombreDependencia);
        }
    }
}

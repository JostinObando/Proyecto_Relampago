using Data;
using Datos;
using System.Data;

namespace Logica
{
    public class Macroproceso_Logica
    {
        private MacroProceso_Data datosMacroproceso = new MacroProceso_Data();

        // Método para obtener todos los macroprocesos
        public DataTable ObtenerTodosLosMacroprocesos()
        {
            return datosMacroproceso.ObtenerTodosLosMacroprocesos();
        }

        // Método para obtener un macroproceso por ID
        public DataTable ObtenerMacroprocesoPorId(string idMacroproceso)
        {
            return datosMacroproceso.ObtenerMacroprocesoPorId(idMacroproceso);
        }

        // Método para agregar un nuevo macroproceso
        public int AgregarMacroproceso(string idMacroproceso, string nombreMacroproceso)
        {
            return datosMacroproceso.AgregarMacroproceso(idMacroproceso, nombreMacroproceso);
        }

        // Método para editar un macroproceso
        public int EditarMacroproceso(string idMacroproceso, string nombreMacroproceso)
        {
            return datosMacroproceso.EditarMacroproceso(idMacroproceso, nombreMacroproceso);
        }

        // Método para eliminar un macroproceso
        public int EliminarMacroproceso(string idMacroproceso)
        {
            return datosMacroproceso.EliminarMacroproceso(idMacroproceso);
        }

        // Método para filtrar macroprocesos
        public DataTable FiltrarMacroprocesos(string idMacroproceso = null, string nombreMacroproceso = null)
        {
            return datosMacroproceso.FiltrarMacroprocesos(idMacroproceso, nombreMacroproceso);
        }
    }
}

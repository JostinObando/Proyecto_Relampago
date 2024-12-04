using Data;
using Datos;
using System.Data;

namespace Logica
{
    public class EjeEstrategico_Logica
    {
        private EjeEstrategico_Datos datosEjeEstrategico = new EjeEstrategico_Datos();

        // Método para obtener todos los ejes estratégicos
        public DataTable ObtenerTodosLosEjesEstrategicos()
        {
            return datosEjeEstrategico.ObtenerTodosLosEjesEstrategicos();
        }

        // Método para obtener un eje estratégico por su ID
        public DataTable ObtenerEjeEstrategicoPorId(string idEje)
        {
            return datosEjeEstrategico.ObtenerEjeEstrategicoPorId(idEje);
        }

        // Método para agregar un nuevo eje estratégico
        public int AgregarEjeEstrategico(string idEje, string nombreEjeEstrategico)
        {
            return datosEjeEstrategico.AgregarEjeEstrategico(idEje, nombreEjeEstrategico);
        }

        // Método para editar un eje estratégico existente
        public int EditarEjeEstrategico(string idEje, string nombreEjeEstrategico)
        {
            return datosEjeEstrategico.EditarEjeEstrategico(idEje, nombreEjeEstrategico);
        }

        // Método para eliminar un eje estratégico
        public int EliminarEjeEstrategico(string idEje)
        {
            return datosEjeEstrategico.EliminarEjeEstrategico(idEje);
        }

        // Método para filtrar ejes estratégicos por id o nombre
        public DataTable FiltrarEjesEstrategicos(string idEje = null, string nombreEjeEstrategico = null)
        {
            return datosEjeEstrategico.FiltrarEjesEstrategicos(idEje, nombreEjeEstrategico);
        }
    }
}

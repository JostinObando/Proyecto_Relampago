using Datos;
using System;
using System.Data;

namespace Logica
{
    public class Procedimientos_Logica
    {
        private Procedimientos_Datos datosProcedimientos = new Procedimientos_Datos();

        // Método para listar todos los procedimientos
        public DataTable ObtenerTodosLosProcedimientos()
        {
            return datosProcedimientos.ObtenerTodosLosProcedimientos();
        }

        // Método para obtener un procedimiento por su ID
        public DataTable ObtenerProcedimientoPorId(string idEje)
        {
            return datosProcedimientos.ObtenerProcedimientoPorId(idEje);
        }

        // Método para agregar un nuevo procedimiento
        public int AgregarProcedimiento(
            string idEje, string idArea, string idDependencia, string tipoProcedimiento, string estado,
            string teletrabajado, string idMacroproceso, string idEjeEstrategico, string tipoDocumento,
            string nombreProcedimiento, string apoyoTecnologico, string anioActualizacion)
        {
            return datosProcedimientos.AgregarProcedimiento(
                idEje, idArea, idDependencia, tipoProcedimiento, estado, teletrabajado,
                idMacroproceso, idEjeEstrategico, tipoDocumento, nombreProcedimiento,
                apoyoTecnologico, anioActualizacion);
        }

        // Método para editar un procedimiento existente
        public int EditarProcedimiento(
            string idEje, string idArea, string idDependencia, string tipoProcedimiento, string estado,
            string teletrabajado, string idMacroproceso, string idEjeEstrategico, string tipoDocumento,
            string nombreProcedimiento, string apoyoTecnologico, string anioActualizacion)
        {
            return datosProcedimientos.EditarProcedimiento(
                idEje, idArea, idDependencia, tipoProcedimiento, estado, teletrabajado,
                idMacroproceso, idEjeEstrategico, tipoDocumento, nombreProcedimiento,
                apoyoTecnologico, anioActualizacion);
        }

        // Método para eliminar un procedimiento
        public int EliminarProcedimiento(string idEje)
        {
            return datosProcedimientos.EliminarProcedimiento(idEje);
        }

        // Método para filtrar procedimientos con parámetros opcionales
        public DataTable FiltrarProcedimientos(
            string idEje = null, string idArea = null, string tipoProcedimiento = null,
            string estado = null, string anioActualizacion = null)
        {
            return datosProcedimientos.FiltrarProcedimientos(idEje, idArea, tipoProcedimiento, estado, anioActualizacion);
        }
    }
}

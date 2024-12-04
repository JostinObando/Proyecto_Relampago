using Datos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Area_Logica
    {
        private Area datosArea = new Area();

        // Método para listar todas las áreas
        public DataTable ObtenerTodasLasAreas()
        {
            return datosArea.ObtenerTodasLasAreas();
        }

        // Método para obtener un área por su ID
        public DataTable ObtenerAreaPorId(string idArea)
        {
            return datosArea.ObtenerAreaPorId(idArea);
        }

        // Método para agregar una nueva área
        public int AgregarArea(string idArea, string nombreArea)
        {
            return datosArea.AgregarArea(idArea, nombreArea);
        }

        // Método para editar un área existente
        public int EditarArea(string idArea, string nombreArea)
        {
            return datosArea.EditarArea(idArea, nombreArea);
        }

        // Método para eliminar un área
        public int EliminarArea(string idArea)
        {
            return datosArea.EliminarArea(idArea);
        }

        // Método para filtrar áreas con parámetros opcionales
        public DataTable FiltrarAreas(string idArea = null, string nombreArea = null)
        {
            return datosArea.FiltrarAreas(idArea, nombreArea);
        }
    }
}

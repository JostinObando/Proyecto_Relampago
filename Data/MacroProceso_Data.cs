using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class MacroProceso_Data
    {
        // Método para agregar un nuevo macroproceso
        public int AgregarMacroproceso(string idMacroproceso, string nombreMacroproceso)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("CrearMacroproceso", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);
                    cmd.Parameters.AddWithValue("@nombreMacroproceso", nombreMacroproceso);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los macroprocesos
        public DataTable ObtenerTodosLosMacroprocesos()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTodosMacroprocesos", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Método para obtener un macroproceso por ID
        public DataTable ObtenerMacroprocesoPorId(string idMacroproceso)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerMacroprocesoPorId", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Método para editar un macroproceso
        public int EditarMacroproceso(string idMacroproceso, string nombreMacroproceso)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EditarMacroproceso", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);
                    cmd.Parameters.AddWithValue("@nombreMacroproceso", nombreMacroproceso);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un macroproceso
        public int EliminarMacroproceso(string idMacroproceso)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EliminarMacroproceso", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para filtrar macroprocesos
        public DataTable FiltrarMacroprocesos(string idMacroproceso = null, string nombreMacroproceso = null)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerMacroprocesoPorFiltro", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros opcionales
                    cmd.Parameters.AddWithValue("@idMacroproceso", (object)idMacroproceso ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombreMacroproceso", (object)nombreMacroproceso ?? DBNull.Value);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }
        }
}

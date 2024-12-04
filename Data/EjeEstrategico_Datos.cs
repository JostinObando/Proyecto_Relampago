using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class EjeEstrategico_Datos
    {

        // Método para agregar un nuevo eje estratégico
        public int AgregarEjeEstrategico(string idEje, string nombreEjeEstrategico)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("CrearEjeEstrategico", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);
                    cmd.Parameters.AddWithValue("@nombreEjeEstrategico", nombreEjeEstrategico);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los ejes estratégicos
        public DataTable ObtenerTodosLosEjesEstrategicos()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTodosLosEjesEstrategicos", oconexion))
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

        // Método para obtener un eje estratégico por su ID
        public DataTable ObtenerEjeEstrategicoPorId(string idEje)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerEjeEstrategicoPorId", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Método para editar un eje estratégico
        public int EditarEjeEstrategico(string idEje, string nombreEjeEstrategico)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EditarEjeEstrategico", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);
                    cmd.Parameters.AddWithValue("@nombreEjeEstrategico", nombreEjeEstrategico);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un eje estratégico
        public int EliminarEjeEstrategico(string idEje)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EliminarEjeEstrategico", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para filtrar ejes estratégicos
        public DataTable FiltrarEjesEstrategicos(string idEje = null, string nombreEjeEstrategico = null)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("FiltrarEjesEstrategicos", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros opcionales
                    cmd.Parameters.AddWithValue("@idEje", (object)idEje ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombreEjeEstrategico", (object)nombreEjeEstrategico ?? DBNull.Value);

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

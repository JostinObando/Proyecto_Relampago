using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Dependecias_Datos
    {
        // Método para agregar una nueva dependencia
        public int AgregarDependencia(string idDependencia, string nombreDependencia)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("CrearDependencia", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);
                    cmd.Parameters.AddWithValue("@nombreDependencia", nombreDependencia);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todas las dependencias
        public DataTable ObtenerTodasLasDependencias()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTodasLasDependencias", oconexion))
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

        // Método para obtener una dependencia por ID
        public DataTable ObtenerDependenciaPorId(string idDependencia)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerDependenciaPorId", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Método para editar una dependencia
        public int EditarDependencia(string idDependencia, string nombreDependencia)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EditarDependencia", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);
                    cmd.Parameters.AddWithValue("@nombreDependencia", nombreDependencia);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar una dependencia
        public int EliminarDependencia(string idDependencia)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EliminarDependencia", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para filtrar dependencias
        public DataTable FiltrarDependencias(string idDependencia = null, string nombreDependencia = null)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerDependenciasPorFiltro", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros opcionales
                    cmd.Parameters.AddWithValue("@idDependencia", (object)idDependencia ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombreDependencia", (object)nombreDependencia ?? DBNull.Value);

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

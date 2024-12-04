using Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Area_Datos
    {
        // Método para agregar una nueva área
        public int AgregarArea(string idArea, string nombreArea)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("CrearArea", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@nombreArea", nombreArea);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todas las áreas
        public DataTable ObtenerTodasLasAreas()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTodasLasAreas", oconexion))
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

        // Método para obtener un área por ID
        public DataTable ObtenerAreaPorId(string idArea)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerAreaPorId", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idArea", idArea);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        return dataTable;
                    }
                }
            }
        }

        // Método para editar un área
        public int EditarArea(string idArea, string nombreArea)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EditarArea", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@nombreArea", nombreArea);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un área
        public int EliminarArea(string idArea)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EliminarArea", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idArea", idArea);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }
        // Método para filtrar áreas
        public DataTable FiltrarAreas(string idArea = null, string nombreArea = null)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("FiltrarAreas", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros opcionales
                    cmd.Parameters.AddWithValue("@idArea", (object)idArea ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@nombreArea", (object)nombreArea ?? DBNull.Value);

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

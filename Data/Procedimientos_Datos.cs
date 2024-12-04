using Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class Procedimientos_Datos
    {
        // Método para agregar un nuevo procedimiento
        public int AgregarProcedimiento(
            string idEje, string idArea, string idDependencia, string tipoProcedimiento, string estado,
            string teletrabajado, string idMacroproceso, string idEjeEstrategico, string tipoDocumento,
            string nombreProcedimiento, string apoyoTecnologico, string anioActualizacion)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("CrearProcedimiento", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);
                    cmd.Parameters.AddWithValue("@tipoProcedimiento", tipoProcedimiento);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@teletrabajado", teletrabajado);
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);
                    cmd.Parameters.AddWithValue("@idEjeEstrategico", idEjeEstrategico);
                    cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                    cmd.Parameters.AddWithValue("@nombreProcedimiento", nombreProcedimiento);
                    cmd.Parameters.AddWithValue("@apoyoTecnologico", apoyoTecnologico);
                    cmd.Parameters.AddWithValue("@anioActualizacion", anioActualizacion);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para obtener todos los procedimientos
        public DataTable ObtenerTodosLosProcedimientos()
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerTodosLosProcedimientos", oconexion))
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

        // Método para obtener un procedimiento por ID
        public DataTable ObtenerProcedimientoPorId(string idEje)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("ObtenerProcedimientoPorId", oconexion))
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

        // Método para editar un procedimiento
        public int EditarProcedimiento(
            string idEje, string idArea, string idDependencia, string tipoProcedimiento, string estado,
            string teletrabajado, string idMacroproceso, string idEjeEstrategico, string tipoDocumento,
            string nombreProcedimiento, string apoyoTecnologico, string anioActualizacion)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EditarProcedimiento", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);
                    cmd.Parameters.AddWithValue("@idArea", idArea);
                    cmd.Parameters.AddWithValue("@idDependencia", idDependencia);
                    cmd.Parameters.AddWithValue("@tipoProcedimiento", tipoProcedimiento);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@teletrabajado", teletrabajado);
                    cmd.Parameters.AddWithValue("@idMacroproceso", idMacroproceso);
                    cmd.Parameters.AddWithValue("@idEjeEstrategico", idEjeEstrategico);
                    cmd.Parameters.AddWithValue("@tipoDocumento", tipoDocumento);
                    cmd.Parameters.AddWithValue("@nombreProcedimiento", nombreProcedimiento);
                    cmd.Parameters.AddWithValue("@apoyoTecnologico", apoyoTecnologico);
                    cmd.Parameters.AddWithValue("@anioActualizacion", anioActualizacion);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para eliminar un procedimiento
        public int EliminarProcedimiento(string idEje)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("EliminarProcedimiento", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idEje", idEje);

                    oconexion.Open();
                    return cmd.ExecuteNonQuery();
                }
            }
        }

        // Método para filtrar procedimientos
        public DataTable FiltrarProcedimientos(
            string idEje = null, string idArea = null, string tipoProcedimiento = null,
            string estado = null, string anioActualizacion = null)
        {
            using (SqlConnection oconexion = new SqlConnection(Conexion.cn))
            {
                using (SqlCommand cmd = new SqlCommand("FiltrarProcedimientos", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros opcionales
                    cmd.Parameters.AddWithValue("@idEje", (object)idEje ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@idArea", (object)idArea ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@tipoProcedimiento", (object)tipoProcedimiento ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@estado", (object)estado ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@anioActualizacion", (object)anioActualizacion ?? DBNull.Value);

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

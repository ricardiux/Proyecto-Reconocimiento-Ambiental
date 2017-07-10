using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    class ActividadData
    {
        private String connectionString;

        public ActividadData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Actividad InsertarActividad(Actividad actividad)
        {
            SqlCommand cmdActividad = new SqlCommand();
            cmdActividad.CommandText = "insertar_actividad";
            cmdActividad.CommandType = System.Data.CommandType.StoredProcedure;
            cmdActividad.Parameters.Add(new SqlParameter("@codActividad", actividad.CodActividad));
            cmdActividad.Parameters.Add(new SqlParameter("@codSubcriterio", actividad.Subcriterio.CodSubcriterio));
            cmdActividad.Parameters.Add(new SqlParameter("@titulo", actividad.Titulo));
            cmdActividad.Parameters.Add(new SqlParameter("@cantidadParticipantes", actividad.CantidadPraticipantes));
            cmdActividad.Parameters.Add(new SqlParameter("@tipoParticipantes", actividad.TipoParticipantes));
            cmdActividad.Parameters.Add(new SqlParameter("@fecha", actividad.Fecha));
            cmdActividad.Parameters.Add(new SqlParameter("@descripcion", actividad.Descripcion));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdActividad.Connection = connection;
                cmdActividad.Transaction = transaction;
                cmdActividad.ExecuteNonQuery();
                actividad.CodActividad = Int32.Parse(cmdActividad.Parameters["@codActividad"].Value.ToString());

                transaction.Commit();
            }
            catch (SqlException ex)
            {
                if (transaction != null)
                    transaction.Rollback();
                throw ex;
            }
            finally
            {
                if (connection != null)
                    connection.Close();
            }//finally

            return actividad;
        }

        public Actividad ObtenerActividadPorId(int idActividad)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerActividad = "obtener_actividad";
            SqlCommand comandoObtenerActividad = new SqlCommand(sqlProcedureObtenerActividad, connection);
            comandoObtenerActividad.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerActividad.Parameters.Add(new SqlParameter("@codActividad", idActividad));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerActividad.ExecuteReader();
                Actividad actividad = new Actividad();
                while (dataReader.Read())
                {
                    actividad.CodActividad = Int32.Parse(dataReader["cod_actividad"].ToString());
                    actividad.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    actividad.Titulo = dataReader["titulo"].ToString();
                    actividad.CantidadPraticipantes = Int32.Parse(dataReader["cantidad_participantes"].ToString());
                    actividad.TipoParticipantes = dataReader["tipo_participantes"].ToString();
                    actividad.Fecha = Convert.ToDateTime(dataReader["fecha"].ToString());
                    actividad.Descripcion = dataReader["descripcion"].ToString();
                }
                return actividad;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }

        public Actividad ObtenerActividadPorSubcriterio(int idSubcriterio)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerActividad = "obtener_actividad_por_subcriterio";
            SqlCommand comandoObtenerActividad = new SqlCommand(sqlProcedureObtenerActividad, connection);
            comandoObtenerActividad.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerActividad.Parameters.Add(new SqlParameter("@codSubcriterio", idSubcriterio));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerActividad.ExecuteReader();
                Actividad actividad = new Actividad();
                while (dataReader.Read())
                {
                    actividad.CodActividad = Int32.Parse(dataReader["cod_actividad"].ToString());
                    actividad.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    actividad.Titulo = dataReader["titulo"].ToString();
                    actividad.CantidadPraticipantes = Int32.Parse(dataReader["cantidad_participantes"].ToString());
                    actividad.TipoParticipantes = dataReader["tipo_participantes"].ToString();
                    actividad.Fecha = Convert.ToDateTime(dataReader["fecha"].ToString());
                    actividad.Descripcion = dataReader["descripcion"].ToString();
                }
                return actividad;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

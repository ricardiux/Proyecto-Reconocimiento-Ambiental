using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    class AccionAdministrativaData
    {
        private String connectionString;

        public AccionAdministrativaData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public AccionAdministrativa InsertarAccion(AccionAdministrativa accion)
        {
            SqlCommand cmdAccion = new SqlCommand();
            cmdAccion.CommandText = "insertar_accion";
            cmdAccion.CommandType = System.Data.CommandType.StoredProcedure;
            cmdAccion.Parameters.Add(new SqlParameter("@codAccion", accion.CodAccion));
            cmdAccion.Parameters.Add(new SqlParameter("@titulo", accion.Titulo));
            cmdAccion.Parameters.Add(new SqlParameter("@detalle", accion.Detalle));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdAccion.Connection = connection;
                cmdAccion.Transaction = transaction;
                cmdAccion.ExecuteNonQuery();
                accion.CodAccion = Int32.Parse(cmdAccion.Parameters["@codAccion"].Value.ToString());

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

            return accion;
        }

        public AccionAdministrativa ObtenerAccionAdministrativaPorId(int idAccion)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerAccion = "obtener_accion";
            SqlCommand comandoObtenerAccion = new SqlCommand(sqlProcedureObtenerAccion, connection);
            comandoObtenerAccion.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerAccion.Parameters.Add(new SqlParameter("@codSubcriterio", idAccion));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerAccion.ExecuteReader();
                AccionAdministrativa accion = new AccionAdministrativa();
                while (dataReader.Read())
                {
                    accion.CodAccion = Int32.Parse(dataReader["cod_accion"].ToString());
                    accion.Titulo = dataReader["titulo"].ToString();
                    accion.Detalle = dataReader["detalle"].ToString();
                }
                return accion;
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

        public AccionAdministrativa ObtenerAccionAdministrativaPorSubcriterio(int idSubcriterio)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerAccion = "obtener_accion_por_subcriterio";
            SqlCommand comandoObtenerAccion = new SqlCommand(sqlProcedureObtenerAccion, connection);
            comandoObtenerAccion.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerAccion.Parameters.Add(new SqlParameter("@codAccion", idSubcriterio));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerAccion.ExecuteReader();
                AccionAdministrativa accion = new AccionAdministrativa();
                while (dataReader.Read())
                {
                    accion.CodAccion = Int32.Parse(dataReader["cod_accion"].ToString());
                    accion.Titulo = dataReader["titulo"].ToString();
                    accion.Detalle = dataReader["detalle"].ToString();
                }
                return accion;
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

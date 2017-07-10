using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    class NormativaData
    {
        private String connectionString;

        public NormativaData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Normativa InsertarNormativa(Normativa normativa)
        {
            SqlCommand cmdNormativa = new SqlCommand();
            cmdNormativa.CommandText = "insertar_normativa";
            cmdNormativa.CommandType = System.Data.CommandType.StoredProcedure;
            cmdNormativa.Parameters.Add(new SqlParameter("@codAccion", normativa.CodNormativa));
            cmdNormativa.Parameters.Add(new SqlParameter("@codSubcriterio", normativa.Subcriterio.CodSubcriterio));
            cmdNormativa.Parameters.Add(new SqlParameter("@titulo", normativa.Titulo));
            cmdNormativa.Parameters.Add(new SqlParameter("@detalle", normativa.Detalle));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdNormativa.Connection = connection;
                cmdNormativa.Transaction = transaction;
                cmdNormativa.ExecuteNonQuery();
                normativa.CodNormativa = Int32.Parse(cmdNormativa.Parameters["@codNormativa"].Value.ToString());

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

            return normativa;
        }

        public Normativa ObtenerNormativaPorId(int idNormativa)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerNormativa = "obtener_normativa";
            SqlCommand comandoObtenerNormativa = new SqlCommand(sqlProcedureObtenerNormativa, connection);
            comandoObtenerNormativa.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerNormativa.Parameters.Add(new SqlParameter("@codNormativa", idNormativa));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerNormativa.ExecuteReader();
                Normativa normativa = new Normativa();
                while (dataReader.Read())
                {
                    normativa.CodNormativa = Int32.Parse(dataReader["cod_normativa"].ToString());
                    normativa.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    normativa.Titulo = dataReader["titulo"].ToString();
                    normativa.Detalle = dataReader["detalle"].ToString();
                }
                return normativa;
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

        public Normativa ObtenerNormativaPorSubCriterio(int idSubcriterio)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerNormativa = "obtener_normativa_por_subcriterio";
            SqlCommand comandoObtenerNormativa = new SqlCommand(sqlProcedureObtenerNormativa, connection);
            comandoObtenerNormativa.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerNormativa.Parameters.Add(new SqlParameter("@codSubcriterio", idSubcriterio));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerNormativa.ExecuteReader();
                Normativa normativa = new Normativa();
                while (dataReader.Read())
                {
                    normativa.CodNormativa = Int32.Parse(dataReader["cod_normativa"].ToString());
                    normativa.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    normativa.Titulo = dataReader["titulo"].ToString();
                    normativa.Detalle = dataReader["detalle"].ToString();
                }
                return normativa;
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

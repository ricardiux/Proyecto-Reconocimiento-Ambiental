using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    class DocumentoData
    {
        private String connectionString;

        public DocumentoData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Documento InsertarDocumento(Documento documento)
        {
            SqlCommand cmdDocumento = new SqlCommand();
            cmdDocumento.CommandText = "insertar_documento";
            cmdDocumento.CommandType = System.Data.CommandType.StoredProcedure;
            cmdDocumento.Parameters.Add(new SqlParameter("@codDocumento", documento.CodDocumento));
            cmdDocumento.Parameters.Add(new SqlParameter("@codSubcriterio", documento.Subcriterio.CodSubcriterio));
            cmdDocumento.Parameters.Add(new SqlParameter("@titulo", documento.Titulo));
            cmdDocumento.Parameters.Add(new SqlParameter("@tipoDocuemnto", documento.TipoDocumento));
            cmdDocumento.Parameters.Add(new SqlParameter("@detalle", documento.Detalle));
            cmdDocumento.Parameters.Add(new SqlParameter("@fuenteEmisor", documento.FuenteEmisor));
            cmdDocumento.Parameters.Add(new SqlParameter("@fecha", documento.Fecha));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdDocumento.Connection = connection;
                cmdDocumento.Transaction = transaction;
                cmdDocumento.ExecuteNonQuery();
                documento.CodDocumento = Int32.Parse(cmdDocumento.Parameters["@codDocumento"].Value.ToString());

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

            return documento;
        }

        public Documento ObtenerDocumentoPorId(int idDocumento)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerDocumento = "obtener_documento";
            SqlCommand comandoObtenerDocumento = new SqlCommand(sqlProcedureObtenerDocumento, connection);
            comandoObtenerDocumento.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDocumento.Parameters.Add(new SqlParameter("@codDocumento", idDocumento));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerDocumento.ExecuteReader();
                Documento documento = new Documento();
                while (dataReader.Read())
                {
                    documento.CodDocumento = Int32.Parse(dataReader["cod_documento"].ToString());
                    documento.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    documento.Titulo = dataReader["titulo"].ToString();
                    documento.TipoDocumento = dataReader["tipo_documento"].ToString();
                    documento.Detalle = dataReader["detalle"].ToString();
                    documento.FuenteEmisor = dataReader["fuente_emisor"].ToString();
                    documento.Fecha = Convert.ToDateTime(dataReader["fecha"].ToString());
                    
                }
                return documento;
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

        public Documento ObtenerDocumentoPorSubcriterio(int idSubcriterio)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string sqlProcedureObtenerDocumento = "obtener_documento_por_subcriterio";
            SqlCommand comandoObtenerDocumento = new SqlCommand(sqlProcedureObtenerDocumento, connection);
            comandoObtenerDocumento.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObtenerDocumento.Parameters.Add(new SqlParameter("@codSubcriterio", idSubcriterio));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObtenerDocumento.ExecuteReader();
                Documento documento = new Documento();
                while (dataReader.Read())
                {
                    documento.CodDocumento = Int32.Parse(dataReader["cod_documento"].ToString());
                    documento.Subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    documento.Titulo = dataReader["titulo"].ToString();
                    documento.TipoDocumento = dataReader["tipo_documento"].ToString();
                    documento.Detalle = dataReader["detalle"].ToString();
                    documento.FuenteEmisor = dataReader["fuente_emisor"].ToString();
                    documento.Fecha = Convert.ToDateTime(dataReader["fecha"].ToString());

                }
                return documento;
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

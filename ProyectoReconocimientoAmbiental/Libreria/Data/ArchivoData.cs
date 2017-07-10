using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    public class ArchivoData
    {
        private String connectionString;
        SqlCommand cmdArchivo;

        public ArchivoData(String connectionString)
        {
            this.connectionString = connectionString;
        }

        public Archivo InsertarAccion(Archivo archivo)
        {
            cmdArchivo = new SqlCommand();
            cmdArchivo.CommandText = "insertar_archivo_informe";
            cmdArchivo.CommandType = System.Data.CommandType.StoredProcedure;
            cmdArchivo.Parameters.Add(new SqlParameter("@codArchivo", archivo.CodArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@codAccion", archivo.Accion.CodAccion));
            cmdArchivo.Parameters.Add(new SqlParameter("@nombre", archivo.Nombre));
            cmdArchivo.Parameters.Add(new SqlParameter("@tipoArchivo", archivo.TipoArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@datos", archivo.Datos));
                        
            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdArchivo.Connection = connection;
                cmdArchivo.Transaction = transaction;
                cmdArchivo.ExecuteNonQuery();
                archivo.CodArchivo = Int32.Parse(cmdArchivo.Parameters["@codArchivo"].Value.ToString());

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

            return archivo;
        }

        public Archivo InsertarActividad(Archivo archivo)
        {
            cmdArchivo = new SqlCommand();
            cmdArchivo.CommandText = "insertar_archivo_fotografia";
            cmdArchivo.CommandType = System.Data.CommandType.StoredProcedure;
            cmdArchivo.Parameters.Add(new SqlParameter("@codArchivo", archivo.CodArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@codAccion", archivo.Actividad.CodActividad));
            cmdArchivo.Parameters.Add(new SqlParameter("@nombre", archivo.Nombre));
            cmdArchivo.Parameters.Add(new SqlParameter("@tipoArchivo", archivo.TipoArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@datos", archivo.Datos));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdArchivo.Connection = connection;
                cmdArchivo.Transaction = transaction;
                cmdArchivo.ExecuteNonQuery();
                archivo.CodArchivo = Int32.Parse(cmdArchivo.Parameters["@codArchivo"].Value.ToString());

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

            return archivo;
        }

        public Archivo InsertarDocumento(Archivo archivo)
        {
            cmdArchivo = new SqlCommand();
            cmdArchivo.CommandText = "insertar_archivo_documento";
            cmdArchivo.CommandType = System.Data.CommandType.StoredProcedure;
            cmdArchivo.Parameters.Add(new SqlParameter("@codArchivo", archivo.CodArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@codAccion", archivo.Documento.CodDocumento));
            cmdArchivo.Parameters.Add(new SqlParameter("@nombre", archivo.Nombre));
            cmdArchivo.Parameters.Add(new SqlParameter("@tipoArchivo", archivo.TipoArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@datos", archivo.Datos));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdArchivo.Connection = connection;
                cmdArchivo.Transaction = transaction;
                cmdArchivo.ExecuteNonQuery();
                archivo.CodArchivo = Int32.Parse(cmdArchivo.Parameters["@codArchivo"].Value.ToString());

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

            return archivo;
        }

        public Archivo InsertarNormativa(Archivo archivo)
        {
            cmdArchivo = new SqlCommand();
            cmdArchivo.CommandText = "insertar_archivo_normativa";
            cmdArchivo.CommandType = System.Data.CommandType.StoredProcedure;
            cmdArchivo.Parameters.Add(new SqlParameter("@codArchivo", archivo.CodArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@codAccion", archivo.Normativa.CodNormativa));
            cmdArchivo.Parameters.Add(new SqlParameter("@nombre", archivo.Nombre));
            cmdArchivo.Parameters.Add(new SqlParameter("@tipoArchivo", archivo.TipoArchivo));
            cmdArchivo.Parameters.Add(new SqlParameter("@datos", archivo.Datos));

            SqlConnection connection = new SqlConnection(connectionString);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                cmdArchivo.Connection = connection;
                cmdArchivo.Transaction = transaction;
                cmdArchivo.ExecuteNonQuery();
                archivo.CodArchivo = Int32.Parse(cmdArchivo.Parameters["@codArchivo"].Value.ToString());

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

            return archivo;
        }


    }
}

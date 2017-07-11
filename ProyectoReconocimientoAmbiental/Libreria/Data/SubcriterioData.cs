using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    public class SubcriterioData
    {
        private String cadenaConexion;

        public SubcriterioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void Insertar(Subcriterio subcriterio, int codCriterio)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureInsertarSubcriterio = "insertar_subcriterio";
            SqlCommand comandoInsertarSubcriterio = new SqlCommand(sqlProcedureInsertarSubcriterio, connection);
            comandoInsertarSubcriterio.CommandType = System.Data.CommandType.StoredProcedure;
            comandoInsertarSubcriterio.Parameters.Add(new SqlParameter("@codCriterio", codCriterio));
            comandoInsertarSubcriterio.Parameters.Add(new SqlParameter("@nombreSubcriterio", subcriterio.NombreSubcriterio));
            try
            {
                connection.Open();
                comandoInsertarSubcriterio.ExecuteNonQuery();
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

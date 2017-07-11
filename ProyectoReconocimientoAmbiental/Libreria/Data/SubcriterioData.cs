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
        public LinkedList<Subcriterio> ObtenerSubcriteriosPorCriterio(int codCriterio)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureObtenerSubcriterios = "obtener_subcriterios_por_criterio";
            SqlCommand comandoObteneSubcriterios = new SqlCommand(sqlProcedureObtenerSubcriterios, connection);
            comandoObteneSubcriterios.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObteneSubcriterios.Parameters.Add(new SqlParameter("@codCriterio", codCriterio));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObteneSubcriterios.ExecuteReader();
                LinkedList<Subcriterio> listaSubcriterios = new LinkedList<Subcriterio>();
                while (dataReader.Read())
                {
                    Subcriterio subcriterio = new Subcriterio();
                    subcriterio.CodSubcriterio = Int32.Parse(dataReader["cod_subcriterio"].ToString());
                    subcriterio.NombreSubcriterio = dataReader["nombre_subcriterio"].ToString();
                    listaSubcriterios.AddLast(subcriterio);
                }
                return listaSubcriterios;
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

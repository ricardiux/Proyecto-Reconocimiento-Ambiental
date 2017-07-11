using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    public class CriterioData
    {
        private String cadenaConexion;

        public CriterioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void Insertar(Criterio criterio, int codArea)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureInsertarCriterio = "insertar_criterio";
            SqlCommand comandoInsertarCriterio = new SqlCommand(sqlProcedureInsertarCriterio, connection);
            comandoInsertarCriterio.CommandType = System.Data.CommandType.StoredProcedure;
            comandoInsertarCriterio.Parameters.Add(new SqlParameter("@nombreCriterio", criterio.NombreCriterio));
            comandoInsertarCriterio.Parameters.Add(new SqlParameter("@codArea", codArea));
            try
            {
                connection.Open();
                comandoInsertarCriterio.ExecuteNonQuery();
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

        public LinkedList<Criterio> ObtenerCriteriosPorArea(int codArea)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureObtenerCriterios = "obtener_criterios_por_area";
            SqlCommand comandoObteneCriterios = new SqlCommand(sqlProcedureObtenerCriterios, connection);
            comandoObteneCriterios.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObteneCriterios.Parameters.Add(new SqlParameter("@codArea", codArea));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObteneCriterios.ExecuteReader();
                LinkedList<Criterio> listaCriterios = new LinkedList<Criterio>();
                while (dataReader.Read())
                {
                    Criterio criterio = new Criterio();
                    criterio.CodCriterio = Int32.Parse(dataReader["cod_criterio"].ToString());
                    criterio.NombreCriterio = dataReader["nombre_criterio"].ToString();
                    listaCriterios.AddLast(criterio);
                }
                return listaCriterios;
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

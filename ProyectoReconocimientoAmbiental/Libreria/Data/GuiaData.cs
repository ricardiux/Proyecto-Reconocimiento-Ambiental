using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Domain;
using System.Data.SqlClient;
using System.Data;

namespace Libreria.Data
{
    public class GuiaData
    {
        private string cadenaConexion;

        public GuiaData(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public void IngresarGuiaAmbiental(Guia guia)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdInsertarGuia = new SqlCommand("insertar_guia_ambiental", conexion);
            cmdInsertarGuia.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parametroCodGuia = new SqlParameter("@cod_guia", SqlDbType.Int);
            parametroCodGuia.Direction = System.Data.ParameterDirection.Output;
            cmdInsertarGuia.Parameters.Add(parametroCodGuia);

            cmdInsertarGuia.Parameters.Add(new SqlParameter("@nombre_guia", guia.NombreGuia));
            cmdInsertarGuia.Parameters.Add(new SqlParameter("@anio_aprobacion", guia.AnioAprobacion));
            cmdInsertarGuia.Parameters.Add(new SqlParameter("@vigencia", guia.Vigencia));
            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                cmdInsertarGuia.Transaction = transaction;
                cmdInsertarGuia.ExecuteNonQuery();

                guia.CodGuia = Int32.Parse(cmdInsertarGuia.Parameters["@cod_guia"].Value.ToString());

                foreach (AreaTematica areas in guia.AreasTematicas)
                {
                    SqlCommand cmdInsertarAreas = new SqlCommand("insertar_area_tematica", conexion);
                    cmdInsertarAreas.Transaction = transaction;
                    cmdInsertarAreas.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarAreas.Parameters.Add(new SqlParameter("@nombre_tematica", areas.NombreTematica));
                    cmdInsertarAreas.Parameters.Add(new SqlParameter("@cod_guia",guia.CodGuia));

                    cmdInsertarAreas.ExecuteNonQuery();

                }
                transaction.Commit();
            }
            catch (SqlException exc)
            {
                transaction.Rollback();
                throw exc;
            }
            finally
            {
                conexion.Close();
            }
            
        }
    }
}

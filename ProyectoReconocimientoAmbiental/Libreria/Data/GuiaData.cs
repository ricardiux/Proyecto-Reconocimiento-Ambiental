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

        public void IngresarGuiaAmbiental(Guia guia, int codAdministrador)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand cmdInsertarGuia = new SqlCommand("insertar_guia_ambiental", conexion);
            cmdInsertarGuia.CommandType = System.Data.CommandType.StoredProcedure;

            SqlParameter parametroCodGuia = new SqlParameter("@cod_guia", SqlDbType.Int);
            parametroCodGuia.Direction = System.Data.ParameterDirection.Output;
            cmdInsertarGuia.Parameters.Add(parametroCodGuia);


            cmdInsertarGuia.Parameters.Add(new SqlParameter("@cod_administrador", codAdministrador));
            cmdInsertarGuia.Parameters.Add(new SqlParameter("@nombre_guia", guia.NombreGuia));

            cmdInsertarGuia.Parameters.Add(new SqlParameter("@anio_publicacion", guia.AnioAprobacion));
            cmdInsertarGuia.Parameters.Add(new SqlParameter("@vigente", guia.Vigente));

            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                cmdInsertarGuia.Transaction = transaction;
                cmdInsertarGuia.ExecuteNonQuery();

                guia.CodGuia = Int32.Parse(cmdInsertarGuia.Parameters["@cod_guia"].Value.ToString());

                foreach (AreaTematica areas in guia.ListaAreasTematicas)
                {
                    SqlCommand cmdInsertarAreas = new SqlCommand("insertar_area_tematica", conexion);
                    cmdInsertarAreas.Transaction = transaction;
                    cmdInsertarAreas.CommandType = System.Data.CommandType.StoredProcedure;
                    cmdInsertarAreas.Parameters.Add(new SqlParameter("@cod_funcionario", areas.Funcionario.CodFuncionario));
                    cmdInsertarAreas.Parameters.Add(new SqlParameter("@nombre_area", areas.NombreTematica));
                    cmdInsertarAreas.Parameters.Add(new SqlParameter("@cod_guia", guia.CodGuia));

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

        
        public LinkedList<Guia> ObtenerGuiasAmbientales()
        {

            SqlConnection conexion = new SqlConnection(cadenaConexion);


            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.Connection = conexion;
            dataAdapter.SelectCommand.CommandText = "obtener_guia_ambiental";
            dataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Guia");

            LinkedList<Guia> guia = new LinkedList<Guia>();

            foreach (DataRow fila in dataSet.Tables["Guia"].Rows)
            {
                int codGuia = Int32.Parse(fila["cod_guia"].ToString());
                String nombreGuia = fila["nombre_guia"].ToString();




                guia.AddLast(new Guia(codGuia, nombreGuia));

            }

            return guia;

        }


    }
}

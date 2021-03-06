﻿using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
   public class AreaTematicaData
    {
        private string cadenaConexion;

        public AreaTematicaData(string cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public LinkedList<AreaTematica> BuscarAreaTematicaPorGuia(int cod_guia)
        {
            SqlConnection conexion = new SqlConnection(cadenaConexion);


            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = new SqlCommand();
            dataAdapter.SelectCommand.Connection = conexion;
            dataAdapter.SelectCommand.CommandText = "obtener_areas_tematicas_por_guia";
            dataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;

            dataAdapter.SelectCommand.Parameters.Add(new SqlParameter("@cod_Guia", cod_guia));


            DataSet dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "Area_Tematica");

            LinkedList<AreaTematica> areasTematicas = new LinkedList<AreaTematica>();

            foreach (DataRow fila in dataSet.Tables["Area_Tematica"].Rows)
            {


                int codArea = Int32.Parse(fila["cod_area"].ToString());
                String nombreArea = fila["nombre_area"].ToString();


                int codFuncionario = Int32.Parse(fila["cod_funcionario"].ToString());
                String nombreFuncionario = fila["nombre_funcionario"].ToString();
                String cedula = fila["cedula"].ToString();
                Funcionario funcionario = new Funcionario();
                funcionario.CodFuncionario = codFuncionario;
                if (nombreFuncionario.Equals("Null"))
                {
                    funcionario.Nombre = "";
                }
                else
                {
                    funcionario.Nombre = nombreFuncionario;
                }

                funcionario.Cedula = Int32.Parse(cedula);

                AreaTematica area = new AreaTematica(codArea, nombreArea, funcionario);
                areasTematicas.AddLast(area);

            }

            return areasTematicas;
        }

        public void AsignarEncargadoDeAreaTematica(int codFuncionario, int codTematica)
        {

            SqlConnection conexion = new SqlConnection(cadenaConexion);
            SqlCommand sqlCommand = new SqlCommand("asignar_encargado_a_area", conexion);
            sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

            sqlCommand.Parameters.Add(new SqlParameter("@cod_funcionario", codFuncionario));
            sqlCommand.Parameters.Add(new SqlParameter("@cod_tematica", codTematica));

            conexion.Open();
            SqlTransaction transaction = conexion.BeginTransaction();

            try
            {
                sqlCommand.Transaction = transaction;
                sqlCommand.ExecuteNonQuery();

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

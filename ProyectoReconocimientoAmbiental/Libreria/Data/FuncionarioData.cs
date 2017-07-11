using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Data
{
    public class FuncionarioData
    {
        private String cadenaConexion;

        public FuncionarioData(String cadenaConexion)
        {
            this.cadenaConexion = cadenaConexion;
        }

        public Boolean FuncionarioRegistrado(String nombreUsuario)
        {
            Boolean registrado = false;
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureObtenerEmpleado = "obtener_funcionario_existente";
            SqlCommand comandoObteneFuncionario = new SqlCommand(sqlProcedureObtenerEmpleado, connection);
            comandoObteneFuncionario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObteneFuncionario.Parameters.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObteneFuncionario.ExecuteReader();
                Funcionario funcionario = new Funcionario();
                while (dataReader.Read())
                {
                    registrado = true;
                }
                return registrado;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }//FuncionarioRegistrado

        public Funcionario ObtenerFuncionarioLogin(String nombreUsuario, String contrasenia)
        {
            SqlConnection connection = new SqlConnection(cadenaConexion);
            string sqlProcedureObtenerEmpleado = "obtener_funcionario_login";
            SqlCommand comandoObteneFuncionario = new SqlCommand(sqlProcedureObtenerEmpleado, connection);
            comandoObteneFuncionario.CommandType = System.Data.CommandType.StoredProcedure;
            comandoObteneFuncionario.Parameters.Add(new SqlParameter("@nombreUsuario", nombreUsuario));
            comandoObteneFuncionario.Parameters.Add(new SqlParameter("@contrasenia", contrasenia));
            try
            {
                connection.Open();
                SqlDataReader dataReader = comandoObteneFuncionario.ExecuteReader();
                Funcionario funcionario = new Funcionario();
                while (dataReader.Read())
                {
                    funcionario.CodFuncionario = Int32.Parse(dataReader["cod_funcionario"].ToString());
                    funcionario.Cedula = Int32.Parse(dataReader["cedula"].ToString());
                    funcionario.Nombre = dataReader["nombre_funcionario"].ToString();
                    funcionario.NombreUsuario = dataReader["nombre_usuario"].ToString();
                    funcionario.Contrasenia = dataReader["contrasenia"].ToString();
                    funcionario.Rol.CodRol = Int32.Parse(dataReader["cod_rol"].ToString());
                    funcionario.Rol.NombreRol = dataReader["nombre_rol"].ToString();
                }
                return funcionario;
            }
            catch (SqlException exc)
            {
                throw exc;
            }
            finally
            {
                connection.Close();
            }
        }//ObtenerFuncionarioLogin
    }
}

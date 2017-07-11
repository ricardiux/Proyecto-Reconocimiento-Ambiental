using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class FuncionarioBusiness
    {
        private FuncionarioData funcionarioData;

        public FuncionarioBusiness(String cadenaConexion)
        {
            this.funcionarioData = new FuncionarioData(cadenaConexion);
        }

        public Boolean FuncionarioRegistrado(String nombreUsuario)
        {
            try
            {
                return this.funcionarioData.FuncionarioRegistrado(nombreUsuario);
            }
            catch (SqlException exc)
            {
                throw exc;
            }
        }

        public Funcionario ObtenerFuncionarioLogin(String nombreUsuario, String contrasenia)
        {
            try
            {
                return this.funcionarioData.ObtenerFuncionarioLogin(nombreUsuario, contrasenia);
            }
            catch (SqlException exc)
            {
                throw exc;
            }
        }

        public AreaTematica ObtenerObtenerAreaTematicaPorFuncionario(int codFuncionario)
        {
            try
            {
                return this.funcionarioData.ObtenerObtenerAreaTematicaPorFuncionario(codFuncionario);
            }
            catch (SqlException exc)
            {
                throw exc;
            }
        }
    }
}

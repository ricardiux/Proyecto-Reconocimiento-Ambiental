using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Funcionario
    {
        private int codFuncionario;
        private int cedula;
        private String nombre;
        private String nombreUsuario;
        private String contrasenia;
        private Rol rol;

        public Funcionario()
        {
            this.rol = new Rol();
        }

        public int CodFuncionario { get => codFuncionario; set => codFuncionario = value; }
        public int Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
        public Rol Rol { get => rol; set => rol = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Rol
    {
        private int codRol;
        private String nombreRol;

        public Rol()
        {

        }

        public int CodRol { get => codRol; set => codRol = value; }
        public string NombreRol { get => nombreRol; set => nombreRol = value; }
    }
}

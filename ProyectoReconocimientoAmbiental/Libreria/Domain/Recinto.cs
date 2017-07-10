using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Recinto
    {
        private int codRecinto;
        private String nombreRecinto;
        private Funcionario funcionario;

        public Recinto()
        {
            this.Funcionario = new Funcionario();
        }

        public int CodRecinto { get => codRecinto; set => codRecinto = value; }
        public string NombreRecinto { get => nombreRecinto; set => nombreRecinto = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}

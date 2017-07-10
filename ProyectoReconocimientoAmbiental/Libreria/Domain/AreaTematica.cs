using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
   public class AreaTematica
    {

        private int codArea;
        private String nombreTematica;

        private Funcionario funcionario;

        public AreaTematica() {
            Funcionario = new Funcionario();
        }

        public AreaTematica(int codAreaTematica, string nombreTematica)
        {
            this.codArea = codAreaTematica;
            this.nombreTematica = nombreTematica;
        }

        public int CodAreaTematica { get => codArea; set => codArea = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
    }
}

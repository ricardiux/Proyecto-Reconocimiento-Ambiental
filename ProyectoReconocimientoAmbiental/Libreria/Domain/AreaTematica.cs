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
        private string nombreArea;

        public AreaTematica() {
            funcionario = new Funcionario();
            
        }

        public AreaTematica(int codArea, string nombreArea, Funcionario funcionario)
        {
            this.codArea = codArea;
            this.nombreArea = nombreArea;
            this.funcionario = funcionario;
        }

        public int CodArea { get => codArea; set => codArea = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
      
    }
}

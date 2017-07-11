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
        private Guia guia;

        public AreaTematica() {
            funcionario = new Funcionario();
            Guia = new Guia();
        }

        public AreaTematica(int codAreaTematica, string nombreTematica)
        {
            this.codArea = codAreaTematica;
            this.nombreTematica = nombreTematica;
        }

        public AreaTematica(int codAreaTematica, string nombreTematica, Guia guia, Funcionario funcionario) : this(codAreaTematica, nombreTematica)
        {
            this.Guia = guia;
            this.funcionario = funcionario;
        }

        public int CodArea { get => codArea; set => codArea = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
        public Funcionario Funcionario { get => funcionario; set => funcionario = value; }
        public Guia Guia { get => guia; set => guia = value; }
    }
}

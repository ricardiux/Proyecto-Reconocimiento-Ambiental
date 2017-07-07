using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
   public class AreaTematica
    {

        private int codAreaTematica;
        private String nombreTematica;

        private Guia guia;

        public AreaTematica() {
            Guia = new Guia();
        }

        public AreaTematica(int codAreaTematica, string nombreTematica)
        {
            this.codAreaTematica = codAreaTematica;
            this.nombreTematica = nombreTematica;
        }

        public int CodAreaTematica { get => codAreaTematica; set => codAreaTematica = value; }
        
        public Guia Guia { get => guia; set => guia = value; }
        public string NombreTematica { get => nombreTematica; set => nombreTematica = value; }
    }
}

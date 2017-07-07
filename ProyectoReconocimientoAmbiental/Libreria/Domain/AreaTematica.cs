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
        private int nombreTematica;

        private Guia guia;

        public AreaTematica() {
            Guia = new Guia();
        }

        public int CodAreaTematica { get => codAreaTematica; set => codAreaTematica = value; }
        public int NombreTematica { get => nombreTematica; set => nombreTematica = value; }
        public Guia Guia { get => guia; set => guia = value; }
    }
}

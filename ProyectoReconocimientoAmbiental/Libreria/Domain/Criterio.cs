using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Criterio
    {
        private int codCriterio;
        private String nombreCriterio;
        private LinkedList<Subcriterio> listaSubcriterios;

        public Criterio()
        {
            this.ListaSubcriterios = new LinkedList<Subcriterio>();
        }

        public int CodCriterio { get => codCriterio; set => codCriterio = value; }
        public string NombreCriterio { get => nombreCriterio; set => nombreCriterio = value; }
        public LinkedList<Subcriterio> ListaSubcriterios { get => listaSubcriterios; set => listaSubcriterios = value; }
    }
}

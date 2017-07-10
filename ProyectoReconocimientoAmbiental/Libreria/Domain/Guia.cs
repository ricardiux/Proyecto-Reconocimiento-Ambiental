using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
   public class Guia
    {

        private int codGuia;
        private String nombreGuia;
        private int anioAprobacion;
        private Boolean vigente;
        private LinkedList<AreaTematica> listaAreasTematicas;

        public Guia() {
            this.listaAreasTematicas = new LinkedList<AreaTematica>();
        }

        public int CodGuia { get => codGuia; set => codGuia = value; }
        public string NombreGuia { get => nombreGuia; set => nombreGuia = value; }
        public int AnioAprobacion { get => anioAprobacion; set => anioAprobacion = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
    }
}

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
        private DateTime anioAprobacion;
        private bool vigencia;

        private LinkedList<AreaTematica> areasTematicas;

        public Guia() {
            AreasTematicas = new LinkedList<AreaTematica>();
        }

        public int CodGuia { get => codGuia; set => codGuia = value; }
        public string NombreGuia { get => nombreGuia; set => nombreGuia = value; }
        public DateTime AnioAprobacion { get => anioAprobacion; set => anioAprobacion = value; }
        public bool Vigencia { get => vigencia; set => vigencia = value; }
        public LinkedList<AreaTematica> AreasTematicas { get => areasTematicas; set => areasTematicas = value; }
    }
}

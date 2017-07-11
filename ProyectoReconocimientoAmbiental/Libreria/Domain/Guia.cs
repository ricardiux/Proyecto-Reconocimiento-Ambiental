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
        private AreaTematica areaTematica;
        private Funcionario funcionario;

        public Guia() {
            this.ListaAreasTematicas = new LinkedList<AreaTematica>();
        }

        public Guia(int codGuia, string nombreGuia)
        {
            this.codGuia = codGuia;
            this.nombreGuia = nombreGuia;
        }

        public Guia(int codGuia, string nombreGuia, AreaTematica areaTematica)
        {
            this.codGuia = codGuia;
            this.nombreGuia = nombreGuia;
            this.areaTematica = areaTematica;
            this.funcionario = funcionario;
        }

        public int CodGuia { get => codGuia; set => codGuia = value; }
        public string NombreGuia { get => nombreGuia; set => nombreGuia = value; }
        public int AnioAprobacion { get => anioAprobacion; set => anioAprobacion = value; }
        public bool Vigente { get => vigente; set => vigente = value; }
        public LinkedList<AreaTematica> ListaAreasTematicas { get => listaAreasTematicas; set => listaAreasTematicas = value; }
    }
}

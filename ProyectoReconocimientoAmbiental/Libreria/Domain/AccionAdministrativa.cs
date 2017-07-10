using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class AccionAdministrativa
    {
        private int codAccion;
        private String titulo;
        private String detalle;
        private Subcriterio subcriterio;

        public AccionAdministrativa()
        {
            subcriterio = new Subcriterio();
        }

        public AccionAdministrativa(int codAccion, string titulo, string detalle, Subcriterio subcriterio)
        {
            this.codAccion = codAccion;
            this.titulo = titulo;
            this.detalle = detalle;
            this.subcriterio = subcriterio;
        }

        public int CodAccion { get => codAccion; set => codAccion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Subcriterio Subcriterio { get => subcriterio; set => subcriterio = value; }
    }
}

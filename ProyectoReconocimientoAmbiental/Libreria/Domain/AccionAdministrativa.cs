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

        public AccionAdministrativa()
        {
        }

        public AccionAdministrativa(int codAccion, string titulo, string detalle)
        {
            this.codAccion = codAccion;
            this.titulo = titulo;
            this.detalle = detalle;
        }

        public int CodAccion { get => codAccion; set => codAccion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}

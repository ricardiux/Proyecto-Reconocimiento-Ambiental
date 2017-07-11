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
        private Archivo archivo;

        public AccionAdministrativa()
        {
            this.Archivo = new Archivo();
        }

        public int CodAccion { get => codAccion; set => codAccion = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Archivo Archivo { get => archivo; set => archivo = value; }
    }
}

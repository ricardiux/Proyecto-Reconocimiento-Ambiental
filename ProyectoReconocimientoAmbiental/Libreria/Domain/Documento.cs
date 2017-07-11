using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Documento
    {
        private int codDocumento;
        private String titulo;
        private String tipoDocumento;
        private String detalle;
        private String fuenteEmisor;
        private DateTime fecha;
        private Archivo archivo;

        public Documento()
        {
            this.Archivo = new Archivo();
        }

        public int CodDocumento { get => codDocumento; set => codDocumento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string FuenteEmisor { get => fuenteEmisor; set => fuenteEmisor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public Archivo Archivo { get => archivo; set => archivo = value; }
    }
}

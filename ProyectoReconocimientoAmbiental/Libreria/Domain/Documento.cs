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

        public Documento()
        {

        }

        public Documento(int codDocumento, string titulo, string tipoDocumento, string detalle, string fuenteEmisor, DateTime fecha)
        {
            this.codDocumento = codDocumento;
            this.titulo = titulo;
            this.tipoDocumento = tipoDocumento;
            this.detalle = detalle;
            this.fuenteEmisor = fuenteEmisor;
            this.fecha = fecha;
        }

        public int CodDocumento { get => codDocumento; set => codDocumento = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string TipoDocumento { get => tipoDocumento; set => tipoDocumento = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public string FuenteEmisor { get => fuenteEmisor; set => fuenteEmisor = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}

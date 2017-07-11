using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Normativa
    {
        private int codNormativa;
        private String titulo;
        private String detalle;
        private Archivo archivo;

        public Normativa()
        {
            this.Archivo = new Archivo();
        }

        public int CodNormativa { get => codNormativa; set => codNormativa = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Archivo Archivo { get => archivo; set => archivo = value; }
    }
}

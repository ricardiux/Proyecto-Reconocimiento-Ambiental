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

        public Normativa()
        {
        }

        public Normativa(int codNormativa, string titulo, string detalle, Archivo archivo)
        {
            this.codNormativa = codNormativa;
            this.titulo = titulo;
            this.detalle = detalle;
        }

        public int CodNormativa { get => codNormativa; set => codNormativa = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
    }
}

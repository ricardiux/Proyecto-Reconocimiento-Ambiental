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
        private Subciterio subcriterio;

        public Normativa()
        {
            subcriterio = new Subciterio();
        }

        public Normativa(int codNormativa, string titulo, string detalle, Archivo archivo. Subcriterio subcriterio)
        {
            this.codNormativa = codNormativa;
            this.titulo = titulo;
            this.detalle = detalle;
            this.subcriterio = subcriterio;
        }

        public int CodNormativa { get => codNormativa; set => codNormativa = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Detalle { get => detalle; set => detalle = value; }
        public Subciterio Subcriterio { get => subcriterio; set => subcriterio = value; }
    }
}

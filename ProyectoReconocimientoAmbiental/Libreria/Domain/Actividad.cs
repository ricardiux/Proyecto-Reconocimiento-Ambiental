using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Actividad
    {
        private int codActividad;
        private String titulo;
        private int cantidadPraticipantes;
        private String tipoParticipantes;
        private DateTime fecha;
        private String descripcion;
        private Subcriterio subcriterio;

        public Actividad()
        {
            subcriterio = new Subcriterio();
        }

        public Actividad(int codActividad, string titulo, int cantidadPraticipantes, string tipoParticipantes, DateTime fecha, string descripcion, Subcriterio subcriterio)
        {
            this.codActividad = codActividad;
            this.titulo = titulo;
            this.cantidadPraticipantes = cantidadPraticipantes;
            this.tipoParticipantes = tipoParticipantes;
            this.fecha = fecha;
            this.descripcion = descripcion;
            this.subcriterio = subcriterio;
        }

        public int CodActividad { get => codActividad; set => codActividad = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int CantidadPraticipantes { get => cantidadPraticipantes; set => cantidadPraticipantes = value; }
        public string TipoParticipantes { get => tipoParticipantes; set => tipoParticipantes = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public Subcriterio Subcriterio { get => subcriterio; set => subcriterio = value; }
    }
}

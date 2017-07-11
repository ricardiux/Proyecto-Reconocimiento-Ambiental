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
        private LinkedList<Archivo> listaArchivos;

        public Actividad()
        {
            this.ListaArchivos = new LinkedList<Archivo>();
        }

        public int CodActividad { get => codActividad; set => codActividad = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public int CantidadPraticipantes { get => cantidadPraticipantes; set => cantidadPraticipantes = value; }
        public string TipoParticipantes { get => tipoParticipantes; set => tipoParticipantes = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public LinkedList<Archivo> ListaArchivos { get => listaArchivos; set => listaArchivos = value; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Subcriterio
    {
        private int codSubcriterio;
        private String nombreSubcriterio;
        private LinkedList<AccionAdministrativa> listaAcciones;
        private LinkedList<Normativa> listaNormativas;
        private LinkedList<Documento> listaDocumentos;
        private LinkedList<Actividad> listaActividades;

        public Subcriterio()
        {
            this.ListaAcciones = new LinkedList<AccionAdministrativa>();
            this.ListaNormativas = new LinkedList<Normativa>();
            this.ListaDocumentos = new LinkedList<Documento>();
            this.ListaActividades = new LinkedList<Actividad>();
        }

        public int CodSubcriterio { get => codSubcriterio; set => codSubcriterio = value; }
        public string NombreSubcriterio { get => nombreSubcriterio; set => nombreSubcriterio = value; }
        public LinkedList<AccionAdministrativa> ListaAcciones { get => listaAcciones; set => listaAcciones = value; }
        public LinkedList<Normativa> ListaNormativas { get => listaNormativas; set => listaNormativas = value; }
        public LinkedList<Documento> ListaDocumentos { get => listaDocumentos; set => listaDocumentos = value; }
        public LinkedList<Actividad> ListaActividades { get => listaActividades; set => listaActividades = value; }
    }
}

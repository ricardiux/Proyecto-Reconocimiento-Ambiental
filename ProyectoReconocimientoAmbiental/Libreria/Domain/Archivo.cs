using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain
{
    public class Archivo
    {
        private int codArchivo;
        private String nombre;
        private String tipoArchivo;
        private String datos;
        private AccionAdministrativa accion;
        private Actividad actividad;
        private Documento documento;
        private Normativa normativa;

        public Archivo()
        {
            accion = new AccionAdministrativa();
            actividad = new Actividad();
            documento = new Documento();
            normativa = new Normativa();
        }

        public Archivo(int codArchivo, string nombre, string tipoArchivo, String datos, AccionAdministrativa accion, Actividad actividad, Documento documento, Normativa normativa)
        {
            this.codArchivo = codArchivo;
            this.nombre = nombre;
            this.tipoArchivo = tipoArchivo;
            this.datos = datos;
            this.accion = accion;
            this.actividad = actividad;
            this.documento = documento;
            this.normativa = normativa;
        }

        public int CodArchivo { get => codArchivo; set => codArchivo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string TipoArchivo { get => tipoArchivo; set => tipoArchivo = value; }
        public string Datos { get => datos; set => datos = value; }
        public AccionAdministrativa Accion { get => accion; set => accion = value; }
        public Actividad Actividad { get => actividad; set => actividad = value; }
        public Documento Documento { get => documento; set => documento = value; }
        public Normativa Normativa { get => normativa; set => normativa = value; }
    }
}

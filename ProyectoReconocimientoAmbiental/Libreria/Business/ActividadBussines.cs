using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class ActividadBussines
    {
        private String cadenaConexion;
        private ActividadData actividadData;

        public ActividadBussines(string cadenaConexion)
        {
            actividadData = new ActividadData(cadenaConexion);
        }

        public void InsertarActividad(Actividad actividad)
        {
            actividadData.InsertarActividad(actividad);
        }

        public void ObtenerActividadPorId(int idActividad)
        {
            actividadData.ObtenerActividadPorId(idActividad);
        }
        public void ObtenerActividadPorSubcriterio(int idSubcriterio)
        {
            actividadData.ObtenerActividadPorSubcriterio(idSubcriterio);
        }
    }
}

using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class AccionAdministrativaBussines
    {
        private AccionAdministrativaData accionAdministrativaData;

        public AccionAdministrativaBussines(string cadenaConexion)
        {
            accionAdministrativaData = new AccionAdministrativaData(cadenaConexion);
        }

        public void InsertarAccion(AccionAdministrativa accion, int codSubcriterio)
        {
            accionAdministrativaData.InsertarAccion(accion, codSubcriterio);
        }

        public void ObtenerAccionAdministrativaPorId(int idAccion)
        {
            accionAdministrativaData.ObtenerAccionAdministrativaPorId(idAccion);
        }
        public void ObtenerAccionAdministrativaPorSubcriterio(int idSubcriterio)
        {
            accionAdministrativaData.ObtenerAccionAdministrativaPorSubcriterio(idSubcriterio);
        }
    }
}

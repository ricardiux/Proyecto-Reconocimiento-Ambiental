using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class NormativaBussines
    {
        private String cadenaConexion;
        private NormativaData normativaData;

        public NormativaBussines(string cadenaConexion)
        {
            normativaData = new NormativaData(cadenaConexion);
        }

        public void InsertarNormativa(Normativa normativa)
        {
            normativaData.InsertarNormativa(normativa);
        }

        public void ObtenerNormativaPorId(int idNormativa)
        {
            normativaData.ObtenerNormativaPorId(idNormativa);
        }
        public void ObtenerNormativaPorSubcriterio(int idSubcriterio)
        {
            normativaData.ObtenerNormativaPorSubCriterio(idSubcriterio);
        }
    }
}

using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class CriterioBusiness
    {
        private CriterioData criterioData;

        public CriterioBusiness(String cadenaConexion)
        {
            this.criterioData = new CriterioData(cadenaConexion);
        }

        public void Insertar(Criterio criterio, int codArea)
        {
            try
            {
                this.criterioData.Insertar(criterio, codArea);
            }
            catch (SqlException exc)
            {
                throw exc;
            }
        }
    }
}

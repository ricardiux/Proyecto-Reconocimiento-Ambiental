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
    public class SubcriterioBusiness
    {
        private SubcriterioData subcriterioData;

        public SubcriterioBusiness(String cadenaConexion)
        {
            this.subcriterioData = new SubcriterioData(cadenaConexion);
        }

        public void Insertar(Subcriterio subcriterio, int codCriterio)
        {
            try
            {
                this.subcriterioData.Insertar(subcriterio, codCriterio);
            }
            catch (SqlException exc)
            {
                throw exc;
            }
        }
    }
}

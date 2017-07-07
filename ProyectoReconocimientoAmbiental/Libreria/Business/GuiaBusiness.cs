using Libreria.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria.Domain;

namespace Libreria.Business
{
   public class GuiaBusiness
    {

        private String cadenaConexion;
        private GuiaData guiaData;

        public GuiaBusiness(string cadenaConexion)
        {
            guiaData = new GuiaData(cadenaConexion);

        }

        public void IngresarGuiaAmbiental(Guia guia)
        {
            guiaData.IngresarGuiaAmbiental(guia);
        }
    }
}

using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
   public class AreaTematicaBusiness
    {
        private AreaTematicaData areaTematicaData;

        public AreaTematicaBusiness(string cadenaConexion)
        {
            areaTematicaData = new AreaTematicaData(cadenaConexion);
        }

        public LinkedList<AreaTematica> BuscarAreaTematicaPorGuia(int codGuia)
        {
            return areaTematicaData.BuscarAreaTematicaPorGuia(codGuia);
        }

        public void AsignarEncargadoDeAreaTematica(int codFuncionario, int codTematica)
        {
            areaTematicaData.AsignarEncargadoDeAreaTematica(codFuncionario, codTematica);
        }

        public LinkedList<Criterio> ObtenerCriteriosPorArea(int codArea)
        {
            return this.areaTematicaData.ObtenerCriteriosPorArea(codArea);
        }

    }
}

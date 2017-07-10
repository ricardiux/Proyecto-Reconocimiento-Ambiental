using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class ArchivoBussines
    {
        private String cadenaConexion;
        private ArchivoData archivoData;

        public ArchivoBussines(string cadenaConexion)
        {
            archivoData = new ArchivoData(cadenaConexion);

        }

        public void InsertarAccion(Archivo archivo)
        {
            archivoData.InsertarAccion(archivo);
        }

        public void InsertarActividad(Archivo archivo)
        {
            archivoData.InsertarActividad(archivo);
        }

        public void InsertarDocumento(Archivo archivo)
        {
            archivoData.InsertarDocumento(archivo);
        }

        public void InsertarNormativa(Archivo archivo)
        {
            archivoData.InsertarNormativa(archivo);
        }
    }
}

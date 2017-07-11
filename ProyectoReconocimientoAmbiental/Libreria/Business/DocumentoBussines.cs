using Libreria.Data;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Business
{
    public class DocumentoBussines
    {
        private DocumentoData documentoData;

        public DocumentoBussines (string cadenaConexion)
        {
            documentoData = new DocumentoData(cadenaConexion);
        }

        public void InsertarDocumento(Documento documento)
        {
            documentoData.InsertarDocumento(documento);
        }

        public void ObtenerDocumentoPorId(int idDocumento)
        {
            documentoData.ObtenerDocumentoPorId(idDocumento);
        }
        public void ObtenerDocumentoPorSubcriterio(int idSubcriterio)
        {
            documentoData.ObtenerDocumentoPorSubcriterio(idSubcriterio);
        }
    }
}

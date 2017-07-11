using Libreria.Business;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AgregarAccion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
                CriterioBusiness criterioBusiness = new CriterioBusiness(cadenaConexion);
                SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(cadenaConexion);
                AreaTematica area = (AreaTematica)Session["areaTematica"];
                lblMensaje.Visible = false;
                //llenamos el DropDown de Criterios
                LinkedList<Criterio> listaCriterios = criterioBusiness.ObtenerCriteriosPorArea(area.CodArea);
                foreach (Criterio criterioActual in listaCriterios)
                {
                    ddlCriterios.Items.Add(new ListItem(criterioActual.NombreCriterio, criterioActual.CodCriterio + ""));
                }
                //llenamos el DropDown de Subcriterios
                int codCriterio = listaCriterios.First().CodCriterio;
                LinkedList<Subcriterio> listasubCriterios = subcriterioBusiness.ObtenerSubcriteriosPorCriterio(codCriterio);
                foreach (Subcriterio subcriterioActual in listasubCriterios)
                {
                    ddlSubcriterios.Items.Add(new ListItem(subcriterioActual.NombreSubcriterio, subcriterioActual.CodSubcriterio + ""));
                }
            }
        }

        protected void btnInsertarAccion_Click(object sender, EventArgs e)
        {
            if(txtDetalle.Text.Equals("") || tbxTitulo.Text.Equals("") || FileUpload1.FileName == null)
            {
                lblMensaje.Text = "Debe llenar todos los campos y cargar un archivo.";
                lblMensaje.Visible = true;
            }
            else
            {
                AccionAdministrativa accion = new AccionAdministrativa();
                accion.Titulo = tbxTitulo.Text;
                accion.Detalle = txtDetalle.Text;                
                int codSubcriterio = Int32.Parse(ddlSubcriterios.SelectedValue.ToString());

                //Leemos el archivo y lo convertimos a arreglo de Bytes
                string filePath = FileUpload1.PostedFile.FileName;
                string filename = System.IO.Path.GetFileName(filePath);
                string ext = System.IO.Path.GetExtension(filename);
                string contenttype = String.Empty;

                //Set the contenttype based on File Extension
                switch (ext)
                {
                    case ".doc":
                        contenttype = "application/vnd.ms-word";
                        break;
                    case ".docx":
                        contenttype = "application/vnd.ms-word";
                        break;
                    case ".xls":
                        contenttype = "application/vnd.ms-excel";
                        break;
                    case ".xlsx":
                        contenttype = "application/vnd.ms-excel";
                        break;
                    case ".jpg":
                        contenttype = "image/jpg";
                        break;
                    case ".png":
                        contenttype = "image/png";
                        break;
                    case ".gif":
                        contenttype = "image/gif";
                        break;
                    case ".pdf":
                        contenttype = "application/pdf";
                        break;
                }
                if (contenttype != String.Empty)
                {

                    Stream fs = FileUpload1.PostedFile.InputStream;
                    BinaryReader br = new BinaryReader(fs);
                    Byte[] bytes = br.ReadBytes((Int32)fs.Length);

                    //Creamos el archivo
                    Archivo archivo = new Archivo();
                    archivo.Nombre = filename;
                    archivo.TipoArchivo = contenttype;
                    archivo.Datos = bytes;

                    accion.Archivo = archivo;

                    try
                    {
                        String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
                        AccionAdministrativaBussines accionAdmnistrativaBusiness = new AccionAdministrativaBussines(cadenaConexion);
                        accionAdmnistrativaBusiness.InsertarAccion(accion, codSubcriterio);
                        String mensaje = "Acción Administrativa ingresada con éxito.";
                        Response.Redirect("ResultadoEncargado.aspx?mensaje=" + mensaje);
                    }
                    catch (SqlException ex)
                    {
                        String mensaje = "Error al ingresar la Acción Administrativa. Vuelva a intentarlo, por favor.";
                        Response.Redirect("ResultadoEncargado.aspx?mensaje=" + mensaje);
                        Console.Write(ex.Message);
                    }


                }
                else
                {
                    lblMensaje.Visible = true;
                    lblMensaje.Text = "No se reconoce el archivo." +
                      " Por favor cargue alguno de los siguientes formatos: Imagen/Word/PDF/Excel.";
                }
            }
        }

        protected void ddlCriterios_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
            SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(cadenaConexion);
            //limpiamos el DropDown de Subcriterios
            ddlSubcriterios.Items.Clear();
            //llenamos el DropDown de Subcriterios
            int codCriterio = Int32.Parse(ddlCriterios.SelectedValue.ToString());
            LinkedList<Subcriterio> listasubCriterios = subcriterioBusiness.ObtenerSubcriteriosPorCriterio(codCriterio);
            foreach (Subcriterio subcriterioActual in listasubCriterios)
            {
                ddlSubcriterios.Items.Add(new ListItem(subcriterioActual.NombreSubcriterio, subcriterioActual.CodSubcriterio + ""));
            }
                        
        }

    }
}
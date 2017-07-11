using Libreria.Business;
using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class AgregarCriterio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AreaTematica area = (AreaTematica)Session["areaTematica"];
            lblNombreAreaTematica.Text = area.NombreTematica;
            lblCodAreaTematica.Text = area.CodArea + "";
            lblCodAreaTematica.Visible = false;
            lblMensaje.Visible = false;
        }

        protected void btnInsertarCriterio_Click(object sender, EventArgs e)
        {
            String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
            CriterioBusiness criterioBusiness = new CriterioBusiness(cadenaConexion);
            if (tbxNombreCriterio.Text.Equals(""))
            {
                lblMensaje.Text = "Debe ingresar un nombre para el nuevo Criterio.";
                lblMensaje.Visible = true;
            }
            else
            {
                try
                {
                    int codArea = Int32.Parse(lblCodAreaTematica.Text.ToString());
                    Criterio criterio = new Criterio();
                    criterio.NombreCriterio = tbxNombreCriterio.Text;
                    criterioBusiness.Insertar(criterio, codArea);
                    String mensaje = "Criterio ingresado con éxito.";
                    Response.Redirect("ResultadoEncargado.aspx?mensaje="+mensaje);
                }
                catch (SqlException ex) {
                    String mensaje = "Error al ingresar el Criterio. Vuelva a intentarlo, por favor.";
                    Response.Redirect("ResultadoEncargado.aspx?mensaje=" + mensaje);
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
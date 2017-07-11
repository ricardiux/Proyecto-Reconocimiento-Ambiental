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
    public partial class AgregarSubcriterio : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
            AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(cadenaConexion);
            SubcriterioBusiness criterioBusiness = new SubcriterioBusiness(cadenaConexion);
            AreaTematica area = (AreaTematica)Session["areaTematica"];
            lblMensaje.Visible = false;
            //llenamos el DropDown de Criterios
            LinkedList<Criterio> listaCriterios = areaTematicaBusiness.ObtenerCriteriosPorArea(area.CodArea);

            foreach(Criterio criterioActual in listaCriterios)
            {
                ddlCriterios.Items.Add(new ListItem(criterioActual.NombreCriterio, criterioActual.CodCriterio + ""));
            }
        }

        protected void btnInsertarSubcriterio_Click(object sender, EventArgs e)
        {
            String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
            SubcriterioBusiness subcriterioBusiness = new SubcriterioBusiness(cadenaConexion);
            if (tbxNombreSubcriterio.Text.Equals(""))
            {
                lblMensaje.Text = "Debe ingresar un nombre para el nuevo Subcriterio.";
                lblMensaje.Visible = true;
            }
            else
            {
                try
                {
                    int codCriterio = Int32.Parse(ddlCriterios.SelectedValue.ToString());
                    Subcriterio subcriterio = new Subcriterio();
                    subcriterio.NombreSubcriterio = tbxNombreSubcriterio.Text;
                    subcriterioBusiness.Insertar(subcriterio, codCriterio);
                    String mensaje = "Subriterio ingresado con éxito.";
                    Response.Redirect("ResultadoEncargado.aspx?mensaje=" + mensaje);
                }
                catch (SqlException ex)
                {
                    String mensaje = "Error al ingresar el Subriterio. Vuelva a intentarlo, por favor.";
                    Response.Redirect("ResultadoEncargado.aspx?mensaje=" + mensaje);
                    Console.Write(ex.Message);
                }
            }
        }
    }
}
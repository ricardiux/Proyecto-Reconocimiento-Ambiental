using Libreria.Business;
using Libreria.Domain;
using System;
using System.Collections.Generic;
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
            SubcriterioBusiness criterioBusiness = new SubcriterioBusiness(cadenaConexion);
            AreaTematica area = (AreaTematica)Session["areaTematica"];
            lblMensaje.Visible = false;
            //llenamos el DropDown de Criterios

        }

        protected void btnInsertarSubcriterio_Click(object sender, EventArgs e)
        {

        }
    }
}
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
    public partial class AreasTematicas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                GuiaBusiness guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);

                LinkedList<Guia> listaGuiasAmbientales = new LinkedList<Guia>();
                listaGuiasAmbientales = guiaBusiness.ObtenerGuiasAmbientales();

                dlGuiasAmbientales.DataSource = listaGuiasAmbientales;
                dlGuiasAmbientales.DataBind();
            }
        }

        protected void dataList_action(object source, DataListCommandEventArgs e)
        {
            Label Label = (Label)e.Item.FindControl("codGuia");
            int codGuia = Int32.Parse(Label.Text);
            Response.Redirect("~/EncargadosTematicas.aspx?codGuia=" + codGuia);
        }

    }
}
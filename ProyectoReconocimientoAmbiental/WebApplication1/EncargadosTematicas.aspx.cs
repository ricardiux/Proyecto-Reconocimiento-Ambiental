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
    public partial class EncargadosTematicas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {

                int codGuia = Int32.Parse(Request.QueryString["codGuia"]);

              
                AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);

                LinkedList<AreaTematica> tematicasEnGuia = new LinkedList<AreaTematica>();
                tematicasEnGuia = areaTematicaBusiness.BuscarAreaTematicaPorGuia(codGuia);



                dlEncargados.DataSource = tematicasEnGuia;
                dlEncargados.DataBind();
            }

        }

        protected void dataList_action(object source, DataListCommandEventArgs e)
        {
            Label Label = (Label)e.Item.FindControl("codAreaTematica");
            int codArea = Int32.Parse(Label.Text);

            DropDownList dropDownList = (DropDownList)e.Item.FindControl("ddlEncargado");
            int codFuncionario = Int32.Parse(dropDownList.SelectedValue);

            AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);

            areaTematicaBusiness.AsignarEncargadoDeAreaTematica(codFuncionario, codArea);

            reload();
        }

        private void reload()
        {

            int codGuia = Int32.Parse(Request.QueryString["codGuia"]);

            AreaTematicaBusiness areaTematicaBusiness = new AreaTematicaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);

            LinkedList<AreaTematica> tematicasEnGuia = new LinkedList<AreaTematica>();
            tematicasEnGuia = areaTematicaBusiness.BuscarAreaTematicaPorGuia(codGuia);



            dlEncargados.DataSource = tematicasEnGuia;
            dlEncargados.DataBind();
        }
    }
}
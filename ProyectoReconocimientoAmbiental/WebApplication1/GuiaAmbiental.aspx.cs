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
    public partial class GuiaAmbiental : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAgregar_Click(object sender, EventArgs e)
        {
           
           int CantidadAreasTematicas= Int32.Parse(lbAreasTematicas.Items.Count.ToString());
            if (CantidadAreasTematicas<9 && tbNombreArea.Text!="") {
                lbEncargados.Items.Add(ddlEncargado.SelectedValue);
                lbAreasTematicas.Items.Add(tbNombreArea.Text);
                tbNombreArea.Text = "";
            }
            


        }

        protected void tbGuardar_Click(object sender, EventArgs e)
        {
            GuiaBusiness guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);
            Guia guia = new Guia();
            guia.NombreGuia = tbNombreGuia.Text;
            guia.AnioAprobacion = Int32.Parse(tbAnio.Text);
            guia.Vigente = true;

            for (int i = 0; i < lbAreasTematicas.Items.Count; i++)
            {
                AreaTematica areaTematica = new AreaTematica();
                
                areaTematica.CodAreaTematica = 0;
                areaTematica.NombreTematica = lbAreasTematicas.Items[i].Text;
                int codFuncionario = Int32.Parse(lbEncargados.Items[i].Text);
                areaTematica.Funcionario.CodFuncionario= codFuncionario;
                guia.ListaAreasTematicas.AddLast(areaTematica);
            
            }            

            guiaBusiness.IngresarGuiaAmbiental(guia);            
   
        }
    }
}
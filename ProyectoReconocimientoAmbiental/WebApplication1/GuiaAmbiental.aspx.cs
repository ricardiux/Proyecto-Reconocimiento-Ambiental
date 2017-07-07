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
                lbAreasTematicas.Items.Add(tbNombreArea.Text);
                tbNombreArea.Text = "";
            }
            


        }

        protected void tbGuardar_Click(object sender, EventArgs e)
        {
            GuiaBusiness guiaBusiness = new GuiaBusiness(WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString);
            Guia guia = new Guia();
            guia.NombreGuia = tbNombreGuia.Text;
            guia.AnioAprobacion = DateTime.Parse(tbAnio.Text);
            guia.Vigencia = true;

            for (int i = 0; i < lbAreasTematicas.Items.Count; i++)
            {
                
                guia.AreasTematicas.AddLast(new AreaTematica(0, lbAreasTematicas.Items[i].Text));

            }
            

            guiaBusiness.IngresarGuiaAmbiental(guia);
            
   
        }
    }
}
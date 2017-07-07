using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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

        }
    }
}
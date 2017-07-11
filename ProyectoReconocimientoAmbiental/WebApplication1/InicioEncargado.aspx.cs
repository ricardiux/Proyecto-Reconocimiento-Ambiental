using Libreria.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class InicioEncargado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Funcionario funcionario = (Funcionario)Session["usuario"];
            if (funcionario == null || !funcionario.Rol.NombreRol.Equals("Encargado"))
            {
                Response.Redirect("Login.aspx");
            }
        }
    }
}
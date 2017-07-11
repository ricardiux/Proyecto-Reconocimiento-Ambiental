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
    public partial class Login1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            lblMensaje.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            String cadenaConexion = WebConfigurationManager.ConnectionStrings["GestionAmbiental"].ConnectionString;
            FuncionarioBusiness funcionarioBusiness = new FuncionarioBusiness(cadenaConexion);

            String nombreUsuario = tbxNombreUsuario.Text;
            String contrasenia = tbxContrasenia.Text;

            if (nombreUsuario.Equals("") || contrasenia.Equals(""))
            {
                String mensaje = "Debe completar todos los campos.";
                lblMensaje.Text = mensaje;
                lblMensaje.Visible = true;
            }
            else if(!funcionarioBusiness.FuncionarioRegistrado(nombreUsuario))
            {
                String mensaje = "Lo sentimos, este usuario no se encuentra registrado. Intente con otro.";
                lblMensaje.Text = mensaje;
                lblMensaje.Visible = true;
            }
            else
            {
                Funcionario funcionario = funcionarioBusiness.ObtenerFuncionarioLogin(nombreUsuario, contrasenia);
                if (funcionario.Nombre == null)
                {
                    String mensaje = "Lo sentimos, la contraseña es incorrecta. Intente nuevamente.";
                    lblMensaje.Text = mensaje;
                    lblMensaje.Visible = true;
                }
                else
                {
                    //Si el usuario existe y la contraseña es correcta, procedemos a verificar su rol
                    if (funcionario.Rol.NombreRol.Equals("Administrador"))
                    {
                        //ponemos en sesión al administrador
                        Session["usuario"] = funcionario;
                        Response.Redirect("InicioAdministrador.aspx");
                    }
                    else if (funcionario.Rol.NombreRol.Equals("Encargado"))
                    {
                        //ponemos en sesión al encargado 
                        Session["usuario"] = funcionario;
                        AreaTematica areaTematica = funcionarioBusiness.ObtenerObtenerAreaTematicaPorFuncionario(funcionario.CodFuncionario);
                        Session["areaTematica"] = areaTematica;
                        Response.Redirect("InicioEncargado.aspx");
                    }
                }
            }
        }
    }
}
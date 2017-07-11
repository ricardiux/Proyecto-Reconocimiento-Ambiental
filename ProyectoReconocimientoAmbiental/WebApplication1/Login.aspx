<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section>
        <div class="formulario">
            <asp:Label ID="Label1" runat="server" Text="Inicio de Sesión" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre de Usuario" Font-Size="Medium"></asp:Label>
            <br />
            <asp:TextBox ID="tbxNombreUsuario" Width="90%" CssClass="form-control" runat="server" Font-Size="Medium"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Contraseña" Font-Size="Medium"></asp:Label>
            <br />
            <asp:TextBox ID="tbxContrasenia" Width="90%" CssClass="form-control" TextMode="Password" runat="server" Font-Size="Medium"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" CssClass="btn btn-success" runat="server" Text="Ingresar" Font-Size="Medium" OnClick="btnLogin_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Medium" ForeColor="Red"></asp:Label>
            <br />
        </div>
    </section>
</asp:Content>

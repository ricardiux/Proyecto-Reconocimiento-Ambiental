<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="AgregarSubcriterio.aspx.cs" Inherits="WebApplication1.AgregarSubcriterio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <section>
        <div class="formulario">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Agregar Subriterio"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Seleccione un Criterio"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCriterios" CssClass="form-control" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Nombre del Subcriterio"></asp:Label>
            <br />
            <asp:TextBox ID="tbxNombreSubcriterio" Font-Size="Medium" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsertarSubcriterio" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnInsertarSubcriterio_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Medium" ForeColor="Red" Text=""></asp:Label>
            <br />
        </div>
    </section>
</asp:Content>

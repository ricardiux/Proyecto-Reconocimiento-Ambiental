<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="AgregarCriterio.aspx.cs" Inherits="WebApplication1.AgregarCriterio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <section>
        <div class="formulario">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Agregar Criterio"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lblNombreAreaTematica" Font-Size="X-Large" runat="server" Text=""></asp:Label>
            <asp:Label ID="lblCodAreaTematica" runat="server" Text=""></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Nombre del Criterio"></asp:Label>
            <br />
            <asp:TextBox ID="tbxNombreCriterio" Font-Size="Medium" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnInsertarCriterio" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnInsertarCriterio_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Medium" ForeColor="Red" Text=""></asp:Label>
            <br />
        </div>
    </section>
</asp:Content>

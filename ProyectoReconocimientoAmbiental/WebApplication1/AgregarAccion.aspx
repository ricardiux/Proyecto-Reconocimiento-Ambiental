<%@ Page Title="" Language="C#" MasterPageFile="~/Encargado.Master" AutoEventWireup="true" CodeBehind="AgregarAccion.aspx.cs" Inherits="WebApplication1.AgregarAccion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <br />
    <section>
        <div class="formulario">
            <asp:Label ID="Label1" runat="server" Font-Size="XX-Large" Text="Agregar Acción Administrativa"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Font-Size="Medium" Text="Seleccione un Criterio"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlCriterios" CssClass="form-control" runat="server" OnSelectedIndexChanged="ddlCriterios_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Font-Size="Medium" Text="Seleccione un Subcriterio"></asp:Label>
            <br />
            <asp:DropDownList ID="ddlSubcriterios" CssClass="form-control" runat="server"></asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Font-Size="Medium" Text="Título"></asp:Label>
            <br />
            <asp:TextBox ID="tbxTitulo" Font-Size="Medium" CssClass="form-control" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label5" runat="server" Font-Size="Medium" Text="Detalle"></asp:Label>
            <br />
            <asp:TextBox id="txtDetalle" TextMode="multiline" CssClass="form-control" Columns="50" Rows="8" runat="server" />
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Font-Size="Medium" Text="Archivo de Informe Técnico"></asp:Label>
            <br />
            <asp:FileUpload ID="FileUpload1" CssClass="form-control" runat="server" />
            <br />
            <br />
            <asp:Button ID="btnInsertarAccion" runat="server" Text="Agregar" CssClass="btn btn-success" OnClick="btnInsertarAccion_Click" />
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" Font-Size="Medium" ForeColor="Red" Text=""></asp:Label>
            <br />
        </div>
    </section>
</asp:Content>

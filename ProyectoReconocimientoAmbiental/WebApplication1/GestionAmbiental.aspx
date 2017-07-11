<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="GestionAmbiental.aspx.cs" Inherits="WebApplication1.GestionAmbiental" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">

        <div class="formGuia">
            <br />
             
            <div>
                
            <asp:Label ID="Label1" runat="server" Text="Nombre de la guia:"></asp:Label>
                <br />
            <asp:TextBox class="input" ID="tbNombreGuia" runat="server"></asp:TextBox>
        <br />
            </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Año:"></asp:Label>
            <br />
            <asp:TextBox class="input" ID="tbAnio" runat="server"></asp:TextBox>
       
        </div>
     
            <h5>Areas Tematicas</h5>
            
            <asp:Label ID="Label4" runat="server" Text="Nombre area tematica:"></asp:Label>
            <br />
            <asp:TextBox class="input" ID="tbNombreArea" runat="server"></asp:TextBox>
            <br />
            
         
            <br />
&nbsp;<asp:Button ID="btAgregar" runat="server" OnClick="btAgregar_Click" Text="Agregar" />
            <br />
            <br />
            <asp:ListBox ID="lbAreasTematicas" runat="server"  Height="153px" Width="192px"></asp:ListBox>
            
            <br />
            <br />
            <asp:Button class="button" ID="tbGuardar" runat="server" OnClick="tbGuardar_Click" Text="Guardar" />
            <br />
      
    </div>
    </div>



</asp:Content>

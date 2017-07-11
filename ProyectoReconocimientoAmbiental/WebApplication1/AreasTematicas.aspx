<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="AreasTematicas.aspx.cs" Inherits="WebApplication1.AreasTematicas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="content">

        <div class="body">
        <br />
             <br />
             <br />
             <br />
            <br />
        <asp:Label ID="Label1" runat="server" Text="Filtrar"></asp:Label>
        <asp:TextBox ID="tbGuia" runat="server"></asp:TextBox>
        
        <asp:Button ID="Button2" runat="server" Text="Button" />
  


    <asp:DataList ID="dlGuiasAmbientales" runat="server" CellSpacing="3" 
        RepeatColumns="1" onitemcommand="dataList_action">

        
        <ItemTemplate>
             
                       
            <table class="table">
                <tr>
                   
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="codGuia" runat="server" Text='<%# Eval("codGuia") %>' />
                        <label>Guia:</label>
                        <asp:Label ID="nombre" runat="server" Text='<%# Eval("nombreGuia") %>' />
                        <br />

    
                    </td>

                    <td>
                          <asp:Button ID="Button1" runat="server" Text="Ver Areas Tematicas"  />
                    </td>

                 </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>

    </div>
   </div>


</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="AreasTematicas.aspx.cs" Inherits="WebApplication1.AreasTematicas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 25px;
            margin-top: 0;
            margin-left: 52px;
            text-align: center;
        }

        td, th {
            border: 1px solid #ddd;
            text-align: left;
        }

        table {
            border-collapse: collapse;
            width: 100%;
        }

        th, td {
            padding: 15px;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   <div class="content">

        <div class="body">
        <br />
             <br />
             <br />
             <br />
            <br />


            <div class="fondo">

            <br />
                <br />

       
  
    <br />
    <br />

    <asp:DataList ID="dlGuiasAmbientales" runat="server" CellSpacing="3" 
        RepeatColumns="1" onitemcommand="dataList_action" CssClass="auto-style1" Width="461px">

        
        <ItemTemplate>
             
                       
            <table class="table">
                <tr>
                   
                </tr>
                <tr>
                    <td>

                        <asp:Label ID="codGuia" runat="server" Text='<%# Eval("codGuia") %>' visible="false" />
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
        <SeparatorStyle BackColor="#999999" />
    </asp:DataList>
        </div>
    </div>
   </div>



</asp:Content>

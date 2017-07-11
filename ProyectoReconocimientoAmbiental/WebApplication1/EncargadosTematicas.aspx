<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EncargadosTematicas.aspx.cs" Inherits="WebApplication1.EncargadosTematicas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <style type="text/css">
        .auto-style1 {
            margin-bottom: 25px;
            margin-top: 0;
            margin-left: 52px;
            text-align:center;
        }

        table, td, th {    
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

        

     <div class="formEncargados">
            <br />
             <br />
             <br />
             <br />
            <br />
         
         <div class="fondo">

    <asp:DataList ID="dlEncargados" runat="server" CellSpacing="3" 
        RepeatColumns="3" onitemcommand="dataList_action">

        
        <ItemTemplate>
             
                       
            <table class="table">
                <tr>
                    <th>
                        <asp:Label ID="Label1" runat="server" Text="Area Tematica"></asp:Label>
                    </th>

                    <th>
                        <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
                    </th>
                </tr>
                <tr>
                    <td>

                        <label>Codigo:</label>
                        <asp:Label ID="codAreaTematica" runat="server" Text='<%# Eval("codArea") %>' />
                        <br />

                        <label>Nombre area tematica:</label>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("nombreTematica") %>' />
                        <br />

                        <label>Encargado:</label>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("funcionario.nombre") %>' />
                        <br />
                        
                      
                        
                    </td>

                    <td>
                        Encargado disponibles:<br />
        <asp:DropDownList class="drop-down" ID="ddlEncargado" runat="server" DataSourceID="SqlDataSource1" DataTextField="nombre_funcionario" DataValueField="cod_funcionario" Height="27px" Width="160px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:GestionAmbiental %>" SelectCommand="Obtener_Funcionarios" SelectCommandType="StoredProcedure"></asp:SqlDataSource>
            <br />  
                        <br /> 

                          <asp:Button ID="Button1" runat="server" Text="Asignar Encargado"  />
                    </td>

                 </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>
    </div>


    </div>

         </div>

</asp:Content>

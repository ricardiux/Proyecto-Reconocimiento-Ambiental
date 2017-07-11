<%@ Page Title="" Language="C#" MasterPageFile="~/Administrador.Master" AutoEventWireup="true" CodeBehind="EncargadosTematicas.aspx.cs" Inherits="WebApplication1.EncargadosTematicas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div >
            <br />
             <br />
             <br />
             <br />
            <br />
         


    <asp:DataList ID="dlEncargados" runat="server" CellSpacing="3" 
        RepeatColumns="3" onitemcommand="dataList_action">

        
        <ItemTemplate>
             
                       
            <table class="table">
                <tr>
                    <th>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("guia.nombreGuia") %>' />
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

                          <asp:Button ID="Button1" runat="server" Text="Asignar Encargado"  />
                    </td>

                 </tr>
            </table>
        </ItemTemplate>
    </asp:DataList>

    </div>

</asp:Content>

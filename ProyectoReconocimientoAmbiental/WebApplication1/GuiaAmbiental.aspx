<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GuiaAmbiental.aspx.cs" Inherits="WebApplication1.GuiaAmbiental" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-bottom: 5px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Nombre de la guia:"></asp:Label>
&nbsp;
            <asp:TextBox ID="tbNombreGuia" runat="server" Width="182px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Año:"></asp:Label>
&nbsp;
            <asp:TextBox ID="tbAnio" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Ingrese las areas tematicas pertenientes"></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Nombre area tematica:"></asp:Label>
&nbsp;
            <asp:TextBox ID="tbNombreArea" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btAgregar" runat="server" OnClick="btAgregar_Click" Text="Agregar" />
            <br />
            <br />
            <asp:ListBox ID="lbAreasTematicas" runat="server" CssClass="auto-style1" Height="153px" Width="192px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="tbGuardar" runat="server" OnClick="tbGuardar_Click" Text="Guardar" />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InfoReclamaciones.aspx.cs" Inherits="MerCadona.ATENCION_CLIENTE.InfoReclamaciones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="cabecera">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_NuestraEmpresa/logomercahorizontal325.gif" />
        </div>
        <div id="content">
            <h1>Lista de reclamaciones</h1>
            <asp:Table ID="tablaReclamacion" runat="server"></asp:Table>

        </div>
        <div id="pie">
            <asp:TextBox ID="TextBox1" runat="server" Height="85px" TextMode="MultiLine" Width="180px"></asp:TextBox>
        </div>
    </div>
    </form>
</body>
</html>

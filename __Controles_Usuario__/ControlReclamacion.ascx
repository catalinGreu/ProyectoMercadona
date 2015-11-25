<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlReclamacion.ascx.cs" Inherits="MerCadona.__Controles_Usuario__.ControlReclamacion" %>
<style type="text/css">
    .auto-style1 {
        width: 197px;
    }
    .auto-style2 {
        width: 210px;
    }
    .auto-style3 {
        width: 117px;
    }
    .auto-style4 {
        width: 132px;
    }
</style>
<table border="2" style="width:900px; border-color:lightgray;">
    <tr>
        <td class="auto-style1">
            <asp:Label ID="Label1" runat="server" Text="Asunto: " Font-Bold="True"></asp:Label>
            <asp:TextBox ID="txtAsunto" runat="server" TextMode="MultiLine" ReadOnly="True"></asp:TextBox>
        </td>
        <td class="auto-style2">
            <asp:Label ID="Label2" runat="server" Text="Mensaje: " Font-Bold="True"></asp:Label>
            <br />
            <asp:TextBox ID="txtMensaje" runat="server" ReadOnly="True" TextMode="MultiLine"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:Label ID="id" runat="server" Text="Nombre:" Font-Bold="True"></asp:Label>
            <br />
            <asp:Label ID="lblNombre" runat="server" Text="Label"></asp:Label>
        </td>
        <td class="auto-style3">
            <asp:Label ID="Label3" runat="server" Text="E-mail: " Font-Bold="True"></asp:Label>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Label"></asp:Label>
        </td>
        <td style="text-align:center;">
            <asp:Button ID="botonBorrar" runat="server" Text="Borrar" Height="35px" Width="104px" />
        </td>
    </tr>
       
</table>


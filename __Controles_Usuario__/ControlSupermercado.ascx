<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlSupermercado.ascx.cs" Inherits="MerCadona.__Controles_Usuario__.ControlSupermercado" %>
<style type="text/css">
    .auto-style1 {
        height: 33px;
    }
</style>
<table border="2" style="width:800px; height:35px; border-color:lightblue;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="labelDir" runat="server" Text="Direccion"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:Label ID="labelCP" runat="server" Text="Codigo postal"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:Label ID="labelTlf" runat="server" Text="Telefono"></asp:Label>
            </td>
            <td class="auto-style1">
                <asp:Label ID="labelHorario" runat="server" Text="horario"></asp:Label>
            </td>
            <td style="text-align:center;" class="auto-style1">
                <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_NuestraEmpresa/parking.png" Width="23px" />
            </td>
        </tr>
        
    </table>
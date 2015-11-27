<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ControlItems.ascx.cs" Inherits="MerCadona.__Controles_Usuario__.ControlItems" %>
<style type="text/css">
    .auto-style3 {
        width: 103px;
    }
   
    .auto-style4 {
        width: 477px;
    }
    .auto-style5 {
        width: 117px;
    }
   
</style>
<table border="2" style="width:100%; border-color:aquamarine;">
    <tr>
        <td class="auto-style4">
            <asp:Label ID="lblDescripcion" runat="server" Text="Label"></asp:Label>
        </td>
        <td style="text-align:center"; class="auto-style5">
            <asp:Label ID="lblPrecio" runat="server" Text="Label"></asp:Label>
        </td>
        <td style="text-align:center"; class="auto-style3"><asp:Button ID="BtnMenosMiniProd" runat="server" Text="-" BackColor="#FF6600" BorderStyle="Solid" BorderWidth="1px" Height="17px"  Width="10px" />
            <asp:Label ID="LblCantidadMiniProd" runat="server" Text="1" Width="20px" style="text-align:center" Font-Size="Small"></asp:Label>
            <asp:Button ID="BtnMasMiniProd" runat="server" Text="+" BackColor="#FF6600" BorderStyle="Solid" BorderWidth="1px" Height="16px" Width="10px" /></td>
        <td style="text-align:center;">
            <asp:Button ID="btnAddToCart" runat="server" Text="Añadir" />
        </td>
    </tr>
    
</table>


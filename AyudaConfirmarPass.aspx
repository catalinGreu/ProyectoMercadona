<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AyudaConfirmarPass.aspx.cs" Inherits="MerCadona.AyudaConfirmarPass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 5px;
            width: 726px;
        }
        .auto-style2 {
            margin-left: 62px;
        }
        .auto-style3 {
            margin-left: 172px;
        }
        .auto-style4 {
            margin-left: 104px;
        }
        .auto-style6 {
            width: 611px;
        }
        .auto-style7 {
            width: 611px;
            margin-left: 27px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
     <div id="container">
        <div style="" id="cabecera">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/ayudaContras.png" />
        </div>
        <div id="content">
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#006600" Text="Email/Usuario: "></asp:Label>
                        <asp:TextBox ID="inputEmail" runat="server" CssClass="auto-style2" ReadOnly="True" Width="467px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblDNI" runat="server" Font-Bold="True" ForeColor="#339933" Text="Contraseña"></asp:Label>
                        <asp:TextBox ID="inputPass" runat="server" Width="470px" MaxLength="30" CssClass="auto-style4" TextMode="Password"></asp:TextBox>
                    </td>
                    
                    <td>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="inputPass2" ControlToValidate="inputPass" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style6">
                        <asp:Label ID="lblEmail" runat="server" Font-Bold="True" ForeColor="#339933" Text="Confirma contraseña"></asp:Label>
                        <asp:TextBox ID="inputPass2" runat="server" CssClass="auto-style3" Width="393px" TextMode="Password" MaxLength="30"></asp:TextBox>
                    </td>
                   
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="inputPass" ControlToValidate="inputPass2" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                    </td>
                   
                </tr>
                <tr>
                    
                    <td class="auto-style7">
                        &nbsp;</td>
                    
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Font-Bold="True" ForeColor="#006600" Text="Enviar" OnClick="btnEnviar_Click" />
                        <asp:Button ID="btnCerrar" runat="server" Font-Bold="True" ForeColor="#006600" Text="Cerrar" OnClick="btnCerrar_Click"  />
                    </td>
                </tr>
               
                <tr>
                    <td style="text-align:center;" class="auto-style6">
                        <asp:Label ID="labelInfo" runat="server" Text="Contraseña modificada con éxito" Font-Bold="True" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div id="pie">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/bottomAyuda.png" Width="731px" />
        </div>
    
    </div>
    </form>
</body>
</html>

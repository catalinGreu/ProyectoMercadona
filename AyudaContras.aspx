<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AyudaContras.aspx.cs" Inherits="MerCadona.AyudaContras" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 180px;
        }
        .auto-style2 {
            margin-left: 71px;
        }
        .auto-style3 {
            width: 373px;
        }
    </style>
</head>
<body style="width: 769px">
    <form id="form1" runat="server">
    <div id="container">
        <div style="" id="cabecera">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/ayudaContras.png" Width="769px" />
        </div>
        <div id="content">
            
            <table class="auto-style1">
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblInfo" runat="server" Font-Bold="True" ForeColor="#006600" Text="Introduzca el Nº Identificación (DNI, NIF, CIF, NIE) y e-mail y pulse enviar. Se le enviará un correo electrónico para que pueda generar una nueva contraseña."></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblDNI" runat="server" Font-Bold="True" ForeColor="#339933" Text="Nº Identificación:"></asp:Label>
                        <asp:TextBox ID="inputDNI" runat="server" Width="470px" MaxLength="9"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputDNI" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                    
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Label ID="lblEmail" runat="server" Font-Bold="True" ForeColor="#339933" Text="E-mail:"></asp:Label>
                        <asp:TextBox ID="inputMail" runat="server" CssClass="auto-style2" Width="470px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputMail" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    </td>
                   
                </tr>
                <tr>
                    
                    <td class="auto-style3">
                        &nbsp;</td>
                    
                    <td>
                        <asp:Button ID="btnEnviar" runat="server" Font-Bold="True" ForeColor="#006600" Text="Enviar" OnClick="btnEnviar_Click" />
                        <asp:Button ID="btnCerrar" runat="server" Font-Bold="True" ForeColor="#006600" Text="Cerrar" OnClick="btnCerrar_Click" />
                    </td>
                </tr>
               
                <tr>
                    <td style="text-align:center;" colspan="2">
                        <asp:Label ID="infoEmail" runat="server" Text="Email enviado con éxito" Visible="False"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <div id="pie">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/bottomAyuda.png" Width="768px" Height="122px" />
        </div>
    
    </div>
    </form>
</body>
</html>

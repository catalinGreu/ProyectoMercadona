<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAdmin.aspx.cs" Inherits="MerCadona.ATENCION_CLIENTE.LoginAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 123px;
        }
        .auto-style2 {
            width: 255px;
        }
        .auto-style3 {
            height: 123px;
            width: 255px;
        }
        .auto-style4 {
            width: 78%;
        }
        .auto-style5 {
            width: 105px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="cabecera" style="position:relative;">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_NuestraEmpresa/logomercahorizontal325.gif" />
            <div style="position:relative; float:right;">
                <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/imagenes_Inicio/admin.png" /></div>
        </div>
        <div id="content">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td style="text-align:center;">
                        <asp:Label ID="labelAcces" runat="server" Text="ACCESO DENEGADO" Font-Bold="True" Font-Names="Segoe UI" Font-Size="Large" ForeColor="#333333" Visible="False"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style1">
                        <table class="auto-style4">
                            <tr>
                                <td class="auto-style5">
                                    <asp:Label ID="Label1" runat="server" Text="NIF:"></asp:Label>
                                </td>
                                <td>
                <asp:TextBox ID="inputNIF" runat="server" Height="23px" Width="164px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputNIF" ErrorMessage="Falta campo" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                            
                            <tr>
                                <td>
                                    <asp:Label ID="Label2" runat="server" Text="Nombre depart: "></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="inputDepart" runat="server" Height="23px" Width="164px"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputDepart" ErrorMessage="Falta campo" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                </td>
                            </tr>
                        </table>
                    </td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:Button ID="btnEntrar" runat="server" OnClick="btnEntrar_Click" Text="Entrar" Width="121px" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="pie"></div>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroClientes.aspx.cs" Inherits="MerCadona.RegistroClientes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .labelsForm{
            color:#008000;
            font-weight:bold;
        }
        .auto-style5 {
            height: 59px;
        }
        .auto-style8 {
            height: 16px;
        }
        .inputs{
            width:175px;
            height:20px;
        }
        .auto-style9 {
            width: 314px;
        }
        .auto-style10 {
            width: 314px;
            height: 59px;
        }
        .auto-style11 {
            width: 314px;
            height: 16px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div id="container">
        <div id="cabecera">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/cabeceraRegistro.png" /></div>
        <div id="content">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*- Campo obligatorio"></asp:Label>
                    </td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10">
                        <asp:Label ID="Label2" runat="server" Text="*Nombre:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="inputNombre" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                    <td class="auto-style10">
                        <asp:Label ID="Label3" runat="server" Text="*Primer apellido:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="inputApe1" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                    <td class="auto-style5">
                        <asp:Label ID="Label4" runat="server" Text="Segundo apellido:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style11">
                        <br />
                    </td>
                    <td class="auto-style11">
                        <br />
                    </td>
                    <td class="auto-style8">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label5" runat="server" Text="*Tipo de identificacion:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Selected="True">DNI</asp:ListItem>
                            <asp:ListItem>NIF</asp:ListItem>
                            <asp:ListItem>Terjeta residente</asp:ListItem>
                            <asp:ListItem>CIF</asp:ListItem>
                            <asp:ListItem>Pasaporte</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label6" runat="server" Text="*Nº Identificacion:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="inputDNI" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                    <td>
                        <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" ForeColor="#008000" Text="Deseo recibir información comercial" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">
                        <asp:Label ID="Label7" runat="server" Text="*Email/Usuario de acceso:" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="inputEmail" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="Label8" runat="server" Text="*Confirmación E-mail" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:TextBox ID="ipnutEmail2" runat="server" CssClass="inputs"></asp:TextBox>
                    </td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="*Fecha de nacimiento" CssClass="labelsForm"></asp:Label>
                        <br />
                        <asp:DropDownList ID="dropDia" runat="server" Height="16px" Width="48px">
                        </asp:DropDownList>
                        <asp:DropDownList ID="dropMes" runat="server">
                        </asp:DropDownList>
                        <asp:DropDownList ID="dropAnio" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style9">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="pie">
            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/pieRegistro.png" />
        </div>
    
    </div>
    </form>
</body>
</html>

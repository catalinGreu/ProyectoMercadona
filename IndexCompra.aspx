<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IndexCompra.aspx.cs" Inherits="MerCadona.IndexCompra" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 334px;
        }

        .auto-style2 {
            width: 349px;
        }

        .auto-style3 {
            width: 601px;
        }

        .auto-style4 {
            width: 370px;
        }

        .auto-style5 {
            width: 100%;
            height: 131px;
        }

        .auto-style6 {
            width: 341px;
        }

        .auto-style7 {
            width: 100%;
        }

        .auto-style8 {
            width: 341px;
            height: 61px;
        }

        .auto-style10 {
            width: 304px;
        }

        .auto-style11 {
            margin-left: 26px;
        }
        #buttons{
            right:20px;
            top:40px;
        }
        .auto-style12 {
            width: 341px;
            height: 154px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="container">
            <div id="cabecera">
                <table style="width: 100%;">
                    <tr>
                        <td class="auto-style1">
                            <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/mercadona_horizontal.gif" />
                        </td>
                        <td class="auto-style2">&nbsp;</td>
                        <td>
                            <asp:Image ID="Image2" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/BienvenidoCompraOnline.png" />
                        </td>
                    </tr>

                </table>

            </div>
            <div id="content">
                <table class="auto-style5">
                    <tr>
                        <td class="auto-style12">
                            <asp:Image ID="Image3" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/circulo2.gif" />
                            &nbsp;<asp:LinkButton ID="linkRegistro" runat="server" Font-Bold="True" ForeColor="Black">Registrate como cliente</asp:LinkButton>
                            <br />
                            <asp:Label ID="Label1" runat="server" Text="A través de esta opción accederá al formulario para convertirse en cliente del Supermercado on-line no teniendo que volver a escribir sus datos."></asp:Label>
                        </td>
                        <td colspan="2" rowspan="2" style="background-color: gold; position: relative;">
                            <asp:Label ID="Label2" runat="server" Text="E-Mail/Usuario   "></asp:Label>
                            <asp:TextBox ID="inputUsuario" runat="server" Width="435px" MaxLength="40"></asp:TextBox>
                            <br />
                            <br />
                            <asp:Label ID="Label3" runat="server" Text="Contraseña             "></asp:Label>
                            <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style11" MaxLength="25" TextMode="Password" Width="435px"></asp:TextBox>
                            <br />
                            <br />
                            <div id="buttons" style="position:relative; float:right;">
                                <asp:Button ID="btnEntrar" runat="server" Text="ENTRAR" Font-Bold="True" ForeColor="DarkGreen" />
                                <asp:Button ID="btnForgot" runat="server" Text="¿Ha olvidado su contraseña?" Font-Bold="True" ForeColor="DarkGreen" OnClick="btnForgot_Click" />

                            </div>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style8">
                            <asp:Image ID="Image4" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/circulo3.gif" />
                            &nbsp;<asp:LinkButton ID="linkClienteRegistrado" runat="server" Font-Bold="True" ForeColor="Black">Cliente registrado</asp:LinkButton>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            <asp:Image ID="Image5" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/circulo4.gif" />
                            <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" ForeColor="Black">Condiciones generales de compra</asp:LinkButton>
                        </td>
                        <td class="auto-style10">&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </div>
            <div id="pie">
                <table class="auto-style7">

                    <tr>
                        <td class="auto-style4">&nbsp;</td>
                        <td class="auto-style3">&nbsp;</td>
                        <td>
                            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/imagenes/imagenes_CompraOnline/imagenes_autentificacion/logos_certificados.jpg" />
                        </td>
                    </tr>
                </table>
            </div>

        </div>
    </form>
</body>
</html>

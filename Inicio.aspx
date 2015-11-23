<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="MerCadona.Inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Mercadona. Supermercados de Confianza</title>
    <style type="text/css">
        .auto-style1 {
            width: 973px;
        }
        .auto-style2 {
            width: 148px;
        }
        .auto-style3 {
            height: 84px;
        }
        .auto-style4 {
            width: 123%;
            height: 470px;
        }
        .auto-style5 {
            width: 2px;
        }
    </style>
</head>
<body style="max-width:100%; overflow-x:hidden; text-align:center;">
    <form id="form1" runat="server">
    <div id="container">
        <div id="cabecera"></div>
        <div id ="contenido" style="text-align:center;" class="auto-style1">
            <table class="auto-style4">
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="4" rowspan="2">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/imagenes/imagenes_Inicio/index_Cabecera.JPG" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td colspan="4">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <asp:ImageButton ID="btnCompraOnline" runat="server" Height="131px" ImageUrl="~/imagenes/imagenes_Inicio/index_Compra.JPG" Width="169px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnFacturaOnline" runat="server" ImageUrl="~/imagenes/imagenes_Inicio/index_Factura.JPG" />
                    </td>
                    <td>
                        <asp:ImageButton ID="btnTrabaja" runat="server" Height="124px" ImageUrl="~/imagenes/imagenes_Inicio/index_trabaja.JPG" Width="181px" />
                    </td>
                    <td>
                        <asp:ImageButton ID="ImageButton1" runat="server" Height="130px" ImageUrl="~/imagenes/imagenes_Inicio/index_corp.JPG" Width="156px" OnClick="ImageButton1_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
        <div id="pie" class="auto-style3">
            <table style="width:100%;">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td rowspan="3">
                        <div style="text-align:center;">
                            <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/imagenes/imagenes_Inicio/img_canalMerc.png" />

                        </div>
                        
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>


    
    </div>
    </form>
</body>
</html>

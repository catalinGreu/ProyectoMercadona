<%@ Page Title="Mercadona - ¿Donde estamos?" Language="C#" MasterPageFile="~/MasterNavBar.Master" AutoEventWireup="true" CodeBehind="DondeSupermercados.aspx.cs" Inherits="MerCadona.DondeSupermercados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 180px;
            
        }
        .auto-style2 {
            width: 180px;
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            width: 180px;
            height: 51px;
        }
        .auto-style5 {
            height: 51px;
        }
        .auto-style6 {
            width: 169px;
        }
        .auto-style7 {
            height: 23px;
            width: 169px;
        }
        .auto-style8 {
            height: 51px;
            width: 169px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:800px;">
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#003300" Text="¿Donde Estamos?"></asp:Label>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#339966" Text="Ajuste su búsqueda"></asp:Label>
            </td>
            <td class="auto-style7"></td>
            <td class="auto-style3" colspan="3"></td>
        </tr>
        <tr>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" Text="Provincia"></asp:Label>
                <br />
                <asp:DropDownList ID="dropProvincia" runat="server">
                    <asp:ListItem Selected="True">MADRID</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style8">
                <asp:Label ID="Label4" runat="server" Text="Localidad"></asp:Label>
                <br />
                <asp:DropDownList ID="dropLocalidades" runat="server">
                    <asp:ListItem Selected="True">Elija localidad</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style5" colspan="3">
                <asp:Label ID="Label5" runat="server" Text="Horario"></asp:Label>
                <br />
                <asp:DropDownList ID="dropHorarios" runat="server">
                    <asp:ListItem>Elija horario</asp:ListItem>
                    <asp:ListItem>09:00 - 21:30</asp:ListItem>
                    <asp:ListItem>09:00 - 22:00</asp:ListItem>
                    <asp:ListItem>10:00 - 22:00</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#006666" Text="MADRID"></asp:Label>
            </td>
            <td class="auto-style6">&nbsp;</td>
            <td colspan="3">&nbsp;</td>
        </tr>
        <tr style="background-color:#006666;">
            <td class="auto-style1">
                <asp:Label ID="Label7" runat="server" Text="Direccion" Font-Bold="True" ForeColor="White"></asp:Label>
            </td>
            <td class="auto-style6">
                <asp:Label ID="Label8" runat="server" Text="CP" Font-Bold="True" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label9" runat="server" Text="Teléfono" Font-Bold="True" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label10" runat="server" Text="Horario" Font-Bold="True" ForeColor="White"></asp:Label>
            </td>
            <td>
                <asp:Label ID="Label11" runat="server" Text="Parking" Font-Bold="True" ForeColor="White"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:Table ID="tablaSupers" runat="server">
                </asp:Table>
            </td>
        </tr>
    </table>
</asp:Content>

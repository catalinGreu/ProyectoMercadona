<%@ Page Title="Formalizar Pedido" Language="C#" MasterPageFile="~/MasterRegistro.Master" AutoEventWireup="true" CodeBehind="Formalizar.aspx.cs" Inherits="MerCadona.Formalizar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 270px;
        }
        .auto-style2 {
            width: 53px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1" colspan="2">
                <asp:Label ID="Label1" runat="server" Text="Cliente: "></asp:Label>
&nbsp;&nbsp;
                <asp:Label ID="lblCliente" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            </td>
            <td colspan="2">
                <asp:Label ID="Label2" runat="server" Text="Nº de cuenta:"></asp:Label>
                <asp:TextBox ID="inputCuenta" runat="server" Width="362px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputCuenta" ErrorMessage="Introduzca una cuenta" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label4" runat="server" Text="Dirección de entrega:    "></asp:Label>
                <asp:Label ID="lblDireccion" runat="server" Font-Bold="True" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="4">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Text="Precio Total a pagar:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Label ID="lblPrecioTotal" runat="server" Font-Bold="True" Font-Size="Larger" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Terminar y Pagar" OnClick="Button1_Click" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MasterRegistro.Master" AutoEventWireup="true" CodeBehind="AltaTlf.aspx.cs" Inherits="MerCadona.AltaTlf" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 204px;
        }
        .auto-style2 {
            width: 256px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td colspan="3">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*- Campo obligatorio"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="3">
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="#003300" Text="*Teléfono"></asp:Label>
&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="inputTlf" runat="server" MaxLength="9"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputTlf" ErrorMessage="Telefono necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="ACEPTAR" />
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="CANCELAR" CausesValidation="false" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

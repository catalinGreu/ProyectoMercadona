<%@ Page Title="Mercadona - Alta direccion" Language="C#" MasterPageFile="~/MasterRegistro.Master" AutoEventWireup="true" CodeBehind="AltaDireccion.aspx.cs" Inherits="MerCadona.AltaDireccion" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 86%;
        }

        .labelsForm {
            color: #008000;
            font-weight: bold;
        }

        .inputs {
            width: 175px;
            height: 20px;
        }
        .auto-style2 {
            width: 369px;
        }
        .auto-style3 {
            width: 137px;
        }
        .auto-style4 {
            width: 273px;
        }
        .auto-style5 {
            width: 142px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="6">
                <asp:Label ID="Label1" runat="server" Text="*- Campo obligatorio" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server" CssClass="labelsForm" Text="Tipo de via"></asp:Label>
                <br />
                <asp:TextBox ID="inputVia" runat="server" CssClass="inputs"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label3" runat="server" CssClass="labelsForm" Text="*Nombre de via"></asp:Label>
                <br />
                <asp:TextBox ID="inputNombreVia" runat="server" CssClass="inputs"></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:Label ID="Label4" runat="server" CssClass="labelsForm" Text="Nº"></asp:Label>
                <br />
                <asp:TextBox ID="inputNum" runat="server"></asp:TextBox>
            </td>
            <td colspan="2">
                <asp:Label ID="Label5" runat="server" CssClass="labelsForm" Text="Piso"></asp:Label>
                <br />
                <asp:TextBox ID="inputPiso" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Label ID="Label6" runat="server" CssClass="labelsForm" Text="Puerta"></asp:Label>
                <br />
                <asp:TextBox ID="inputPuerta" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputNombreVia" ErrorMessage="Falta Nombre via" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label7" runat="server" CssClass="labelsForm" Text="Bloque"></asp:Label>
                <br />
                <asp:TextBox ID="inputBloque" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label8" runat="server" CssClass="labelsForm" Text="Escalera"></asp:Label>
                <br />
                <asp:TextBox ID="inputEscalera" runat="server"></asp:TextBox>
            </td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Label ID="Label9" runat="server" CssClass="labelsForm" Text="*Localiad"></asp:Label>
                <br />
                <asp:TextBox ID="inputLoc" runat="server" CssClass="inputs"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputLoc" ErrorMessage="Falta localidad" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style4">
                <asp:Label ID="Label10" runat="server" CssClass="labelsForm" Text="Código Postal"></asp:Label>
                <br />
                <asp:TextBox ID="TextBox1" runat="server" MaxLength="5"></asp:TextBox>
            </td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="4">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td colspan="2" style="text-align:center" class="auto-style5">
                &nbsp;</td>
            <td style="text-align:center" colspan="2">
                <asp:Button ID="btnAceptar" runat="server" Text="ACEPTAR" Font-Bold="True" ForeColor="#003300" OnClick="btnAceptar_Click" />
                <asp:Button ID="btnCerrar" runat="server" OnClick="btnCerrar_Click" CausesValidation="false" Text="CERRAR" Font-Bold="True" ForeColor="#003300" />
            </td>
        </tr>
    </table>
</asp:Content>

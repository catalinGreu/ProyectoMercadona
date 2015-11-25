<%@ Page Title="Mercadona - Atención al cliente" Language="C#" MasterPageFile="~/MasterNavBar.Master" AutoEventWireup="true" CodeBehind="AtencionCliente.aspx.cs" Inherits="MerCadona.AtencionCliente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 191px;
        }
        .auto-style2 {
            width: 146px;
        }
        .auto-style3 {
            width: 191px;
            height: 38px;
        }
        .auto-style4 {
            width: 146px;
            height: 38px;
        }
        .auto-style5 {
            height: 38px;
        }
        .auto-style6 {
            width: 231px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width:100%;">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2" colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#006600" Text="ATENCIÓN AL CLIENTE"></asp:Label>
            </td>
            <td class="auto-style2" colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2" colspan="4">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label2" runat="server" Text="Información, sugerencias, reclamaciones...Llámanos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td style="text-align:center;" class="auto-style2" colspan="4">
                <asp:Label ID="Label3" runat="server" Font-Bold="True" Font-Size="X-Large" ForeColor="#0099FF" Text="900 500 103"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label4" runat="server" Text="Además si lo desea puede hacerlo a través de este formulario"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">
                <asp:Label ID="Label5" runat="server" Text="Asunto"></asp:Label>
                <asp:Label ID="Label6" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*"></asp:Label>
            </td>
            <td colspan="4" class="auto-style4">
                <asp:RadioButtonList ID="radioList" runat="server">
                    <asp:ListItem Value="Felicitacion">Felicitacion</asp:ListItem>
                    <asp:ListItem Value="Sugerencia">Sugerencia</asp:ListItem>
                    <asp:ListItem Value="Solicitud de informacion">Solicitud de informacion</asp:ListItem>
                    <asp:ListItem Value="Reclamacion">Reclamacion</asp:ListItem>
                </asp:RadioButtonList>
                <br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="radioList" ErrorMessage="Campo necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style5">
                <br />
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label7" runat="server" Text="Escriba su mensaje"></asp:Label>
                <asp:Label ID="Label8" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="#CC0000" Text="*"></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputMensaje" ErrorMessage="Debe escribir mensaje" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:TextBox ID="inputMensaje" runat="server" Height="113px" TextMode="MultiLine" Width="896px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label9" runat="server" Font-Bold="True" Text="Datos personales"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style6">
                <asp:Label ID="Label10" runat="server" Text="Nombre: "></asp:Label>
                <asp:TextBox ID="inputNombre" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="inputNombre" ErrorMessage="Nombre necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label11" runat="server" Text="Apellido1:  "></asp:Label>
                <asp:TextBox ID="inputApe1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="inputApe1" ErrorMessage="Apellido necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td colspan="3">
                <asp:Label ID="Label12" runat="server" Text="DNI: "></asp:Label>
                <asp:TextBox ID="inputDNI" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="inputDNI" ErrorMessage="DNI required" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label13" runat="server" Text="Apellido2: "></asp:Label>
                <asp:TextBox ID="inputApe2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label14" runat="server" Font-Bold="True" Text="Dirección de contacto"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style6">
                <asp:Label ID="Label15" runat="server" Text="Provincia: "></asp:Label>
                <asp:TextBox ID="inputProvincia" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="inputProvincia" ErrorMessage="Provincia necesaria" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label16" runat="server" Text="Códig Postal:  "></asp:Label>
                <asp:TextBox ID="inputCP" runat="server" MaxLength="5"></asp:TextBox>
                <br />
                <br />
                <asp:Label ID="Label19" runat="server" Text="Nombre de vía: "></asp:Label>
                <asp:TextBox ID="inputNomVia" runat="server"></asp:TextBox>
            </td>
            <td colspan="3">
                <asp:Label ID="Label17" runat="server" Text="Localidad: "></asp:Label>
                <asp:TextBox ID="inputLoc" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="inputLoc" ErrorMessage="Localidad incompleta" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                <br />
                <br />
                <asp:Label ID="Label18" runat="server" Text="Tipo de vía: "></asp:Label>
                <asp:TextBox ID="inputVia" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:Label ID="Label20" runat="server" Font-Bold="True" Text="Datos de contacto"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="3" class="auto-style6">
                <asp:Label ID="Label21" runat="server" Text="Teléfono: "></asp:Label>
                <asp:TextBox ID="inputTlf" runat="server" MaxLength="9" TextMode="Phone"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="inputTlf" ErrorMessage="Telefono necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
            <td colspan="3">
                <asp:Label ID="labelmail" runat="server" Text="E-mail:  "></asp:Label>
                <asp:TextBox ID="inputMail" runat="server" TextMode="Email"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="inputMail" ErrorMessage="Mail necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td colspan="6">&nbsp;</td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:CheckBox ID="checkBox1" runat="server" />
                <asp:Label ID="Label22" runat="server" Text=" Soy mayor de 14 años y he leído y acepto la Política de Confidencialidad y Protección de Datos"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:CheckBox ID="checkBox2" runat="server" />
                <asp:Label ID="Label23" runat="server" Text="Autorizo a que mis datos se utilicen para informarme de productos y servicios, incluido por vía electrónica"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="6">
                <asp:CheckBox ID="checkBox3" runat="server" />
                <asp:Label ID="Label24" runat="server" Text="Firmar digitalmente"></asp:Label>
            </td>
        </tr>
        <tr>
            <td colspan="2">&nbsp;</td>
            <td colspan="2" style="text-align:center;">
                <asp:Button ID="buttonEnviar" runat="server" Text="Enviar consulta" OnClick="buttonEnviar_Click" />
            </td>
            <td colspan="2">&nbsp;</td>
        </tr>
    </table>
</asp:Content>

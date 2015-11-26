<%@ Page Title="Mercadona - Bienvenido al Carrito Online" Language="C#" MasterPageFile="~/MasterRegistro.Master" AutoEventWireup="true" CodeBehind="RegistroClientes2.aspx.cs" Inherits="MerCadona.RegistroClientes2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 441px;
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
            width: 393px;
        }

        .auto-style4 {
            width: 1317px;
        }

        .auto-style5 {
            width: 346px;
        }

        .auto-style6 {
            width: 346px;
            height: 57px;
        }

        .auto-style7 {
            width: 393px;
            height: 57px;
        }

        .auto-style8 {
            width: 441px;
            height: 57px;
        }

        .auto-style9 {
            width: 463px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="content" class="auto-style4">
        <table style="width: 100%;">
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*- Campo obligatorio"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="*Nombre:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputNombre" runat="server" CssClass="inputs"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="inputNombre" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="*Primer apellido:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputApe1" runat="server" CssClass="inputs"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="inputApe1" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">
                    <asp:Label ID="Label4" runat="server" Text="Segundo apellido:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="inputs"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <br />
                </td>
                <td class="auto-style2">
                    <br />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label5" runat="server" Text="*Tipo de identificacion:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:DropDownList ID="dropIdentificacion" runat="server">
                        <asp:ListItem Selected="True">DNI</asp:ListItem>
                        <asp:ListItem>NIF</asp:ListItem>
                        <asp:ListItem>Terjeta residente</asp:ListItem>
                        <asp:ListItem>CIF</asp:ListItem>
                        <asp:ListItem>Pasaporte</asp:ListItem>
                    </asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="dropIdentificacion" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label6" runat="server" Text="*Nº Identificacion:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputDNI" runat="server" CssClass="inputs"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="inputDNI" ErrorMessage="Faltan campos" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style1">
                    <asp:CheckBox ID="CheckBox1" runat="server" Font-Bold="True" ForeColor="#008000" Text="Deseo recibir información comercial" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6">
                    <asp:Label ID="Label7" runat="server" Text="*Email/Usuario de acceso:" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputEmail" runat="server" CssClass="inputs"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="ipnutEmail2" ControlToValidate="inputEmail" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td class="auto-style7">
                    <asp:Label ID="Label8" runat="server" Text="*Confirmación E-mail" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:TextBox ID="ipnutEmail2" runat="server" CssClass="inputs"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="inputEmail" ControlToValidate="ipnutEmail2" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td class="auto-style8">
                    <asp:Label ID="Label9" runat="server" Text="*Fecha de nacimiento" CssClass="labelsForm"></asp:Label>
                    <br />
                    <asp:DropDownList ID="dropDia" runat="server" Height="20px" Width="40 px">
                        <asp:ListItem Selected="True"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="dropMes" runat="server">
                        <asp:ListItem Selected="True"></asp:ListItem>
                    </asp:DropDownList>
                    <asp:DropDownList ID="dropAnio" runat="server">
                        <asp:ListItem Selected="True"></asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label13" runat="server" CssClass="labelsForm" Text="*Contraseña"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputPasswd" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator3" runat="server" ControlToCompare="inputPass2" ControlToValidate="inputPasswd" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label14" runat="server" CssClass="labelsForm" Text="*Repite contraseña"></asp:Label>
                    <br />
                    <asp:TextBox ID="inputPass2" runat="server" CssClass="inputs" TextMode="Password"></asp:TextBox>
                    <asp:CompareValidator ID="CompareValidator4" runat="server" ControlToCompare="inputPasswd" ControlToValidate="inputPass2" ErrorMessage="No coinciden" Font-Bold="True" ForeColor="#CC0000"></asp:CompareValidator>
                </td>
                <td class="auto-style1">
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="dropDia" ErrorMessage="Dia" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="dropMes" ErrorMessage="Mes" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="dropAnio" ErrorMessage="Año" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label10" runat="server" Text="*Direccion" CssClass="labelsForm"></asp:Label>
                    <asp:DropDownList ID="dropDireccion" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnAltaDir" runat="server" Text="ALTA" Width="94px" Font-Bold="True" ForeColor="#006600" OnClick="btnAltaDir_Click" CausesValidation="false" />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label11" runat="server" Text="*Teléfonos" CssClass="labelsForm"></asp:Label>
                    <asp:DropDownList ID="dropTelefono" runat="server">
                    </asp:DropDownList>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnAltaTlf" runat="server" Text="ALTA" Width="94px" Font-Bold="True" ForeColor="#006600" OnClick="btnAltaTlf_Click" CausesValidation="false" />
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">
                    <asp:CheckBox ID="CheckBox2" runat="server" />
                    <asp:Label ID="Label12" runat="server" Text="Acepto políticas de privacidad."></asp:Label>
                </td>
                <td class="auto-style1">
                    <asp:Button ID="btnEnviarAlta" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="#003300" OnClick="btnEnviarAlta_Click" Text="ENVIAR ALTA" />
                    <asp:Button ID="btnCerrar" runat="server" Font-Bold="True" Font-Size="Smaller" ForeColor="#003300" OnClick="Button1_Click" Text="CERRAR" CausesValidation="false" />
                </td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <table runat="server" id="tablaForm" style="width: 100%;">
                        <tr>
                            <td colspan="6">
                                <asp:Label ID="Label15" runat="server" Text="*- Campo obligatorio" Font-Bold="True" ForeColor="#CC0000"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">&nbsp;</td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:Label ID="Label16" runat="server" CssClass="labelsForm" Text="Tipo de via"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputVia" runat="server" CssClass="inputs"></asp:TextBox>
                            </td>
                            <td class="auto-style4">
                                <asp:Label ID="Label17" runat="server" CssClass="labelsForm" Text="*Nombre de via"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputNombreVia" runat="server" CssClass="inputs"></asp:TextBox>
                            </td>
                            <td class="auto-style3">
                                <asp:Label ID="Label18" runat="server" CssClass="labelsForm" Text="Nº"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputNum" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="2">
                                <asp:Label ID="Label19" runat="server" CssClass="labelsForm" Text="Piso"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputPiso" runat="server"></asp:TextBox>
                            </td>
                            <td>
                                <asp:Label ID="Label20" runat="server" CssClass="labelsForm" Text="Puerta"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputPuerta" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="inputNombreVia" ErrorMessage="Falta Nombre via" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:Label ID="Label21" runat="server" CssClass="labelsForm" Text="Bloque"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputBloque" runat="server"></asp:TextBox>
                            </td>
                            <td class="auto-style4">
                                <asp:Label ID="Label22" runat="server" CssClass="labelsForm" Text="Escalera"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputEscalera" runat="server"></asp:TextBox>
                            </td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">&nbsp;</td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">
                                <asp:Label ID="Label23" runat="server" CssClass="labelsForm" Text="*Localiad"></asp:Label>
                                <br />
                                <asp:TextBox ID="inputLoc" runat="server" CssClass="inputs"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="inputLoc" ErrorMessage="Falta localidad" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                            </td>
                            <td class="auto-style4">
                                <asp:Label ID="Label24" runat="server" CssClass="labelsForm" Text="Código Postal"></asp:Label>
                                <br />
                                <asp:TextBox ID="TextBox2" runat="server" MaxLength="5"></asp:TextBox>
                            </td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">&nbsp;</td>
                            <td colspan="4">&nbsp;</td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">&nbsp;</td>
                            <td colspan="2" style="text-align: center" class="auto-style5">&nbsp;</td>
                            <td style="text-align: center" colspan="2">
                                <asp:Button ID="btnAceptarDir" runat="server" Text="ACEPTAR" Font-Bold="True" ForeColor="#003300" Height="26px" OnClick="btnAceptarDir_Click" />
                                <asp:Button ID="btnCerrarDir" runat="server" CausesValidation="false" Text="CERRAR" Font-Bold="True" ForeColor="#003300" OnClick="btnCerrarDir_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style9">&nbsp;</td>
                            <td class="auto-style4">&nbsp;</td>
                            <td colspan="2" style="text-align: center" class="auto-style5">&nbsp;</td>
                            <td style="text-align: center" colspan="2">&nbsp;</td>
                        </tr>
                        <tr>
                            <td colspan="6">
                                
                            </td>
                        </tr>
                        <tr>
                            <td colspan="6">
                                <table id="tablaTlf" runat="server" style="width: 100%;">
                                    <tr>
                                        <td colspan="3">
                                            <asp:Label ID="Label25" runat="server" Font-Bold="True" ForeColor="#CC0000" Text="*- Campo obligatorio"></asp:Label>
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
                                            <asp:Label ID="Label26" runat="server" Font-Bold="True" ForeColor="#003300" Text="*Teléfono"></asp:Label>
                                            &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="inputTlf" runat="server" MaxLength="9"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="inputTlf" ErrorMessage="Telefono necesario" Font-Bold="True" ForeColor="#CC0000"></asp:RequiredFieldValidator>
                                        </td>
                                        <td>&nbsp;</td>
                                        <td>&nbsp;</td>
                                    </tr>
                                    <tr>
                                        <td>&nbsp;</td>
                                        <td class="auto-style2">&nbsp;</td>
                                        <td class="auto-style1">&nbsp;</td>
                                        <td>
                                            <asp:Button ID="btnAceptarTlf" runat="server" Text="ACEPTAR" OnClick="btnAceptarTlf_Click" />
                                            <asp:Button ID="btnCancelarTlf" runat="server" Text="CANCELAR" CausesValidation="false" OnClick="btnCancelarTlf_Click" />
                                        </td>
                                        <td>&nbsp;</td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>

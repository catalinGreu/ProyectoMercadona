<%@ Page Title="Mercadona - ¿Donde estamos?" Language="C#" MasterPageFile="~/MasterNavBar.Master" AutoEventWireup="true" CodeBehind="DondeEstamos.aspx.cs" Inherits="MerCadona.DondeEstamos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 85px;
        }

        .auto-style2 {
            margin-left: 0px;
        }

        .auto-style3 {
            width: 23px;
        }
        
      
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="container">
        <div id="cabecera">
            <asp:Label ID="Label1" runat="server" Text="¿DONDE ESTAMOS?" Font-Bold="True" ForeColor="#006600"></asp:Label>
        </div>
        <div id="content">
            <asp:Label ID="Label4" runat="server" Text="Situacion Geografica" Font-Bold="True" ForeColor="#006666"></asp:Label>
            <div id="info" style="border: solid; width: 500px;">

                <table style="width: 100%;">
                    <tr>
                        <td colspan="3">
                            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="#006666" Text="Haga clic sobre el nombre de la provincia de la cual desea obtener información acerca de sus supermercados."></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            <asp:Label ID="Label2" runat="server" Text="Elija provincia"></asp:Label>
                        </td>
                        <td class="auto-style3">
                            <asp:DropDownList ID="dropProvincias" runat="server" CssClass="auto-style2">
                            </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" />
                        </td>
                    </tr>
                    <tr>
                        <td colspan="3">
                            <asp:TextBox ID="TextBox1" runat="server" Height="118px" TextMode="MultiLine" Width="201px"></asp:TextBox>
                        </td>
                    </tr>
                </table>

            </div>

        </div>
    </div>
</asp:Content>

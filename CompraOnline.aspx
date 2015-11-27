<%@ Page Title="Mercadona - Tienda" Language="C#" MasterPageFile="~/MasterCompraOnLine.Master" AutoEventWireup="true" CodeBehind="CompraOnline.aspx.cs" Inherits="MerCadona.CompraOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="centro" runat="server">
    <asp:Table ID="tablaProductos" runat="server"></asp:Table>
    <br />
    <asp:Image ID="Image4" runat="server" CssClass="auto-style1" ImageUrl="~/imagenes/imagenes_CompraOnline/portadainicioComprarOnLine.png" Width="877px" />
</asp:Content>

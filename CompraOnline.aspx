<%@ Page Title="Mercadona - Tienda" Language="C#" MasterPageFile="~/MasterCompraOnLine.Master" AutoEventWireup="true" CodeBehind="CompraOnline.aspx.cs" Inherits="MerCadona.CompraOnline" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="centro" runat="server">
    <asp:Table ID="tablaProductos" runat="server"></asp:Table>
    <asp:TextBox ID="TextBox1" runat="server" Height="120px" TextMode="MultiLine" Width="209px"></asp:TextBox>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/MyMaster.Master" AutoEventWireup="true" CodeBehind="Secundaria.aspx.cs" Inherits="lab_2_4_1.Secundaria" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblOrigem" runat="server" AssociatedControlID="txtOrigem" Text="Texto de Origem: " />
    <asp:TextBox ID="txtOrigem" runat="server" />
    <br />

    <asp:Label ID="lblDestino" runat="server" AssociatedControlID="txtDestino"  Text="Texto de Destino: " />
    <asp:TextBox ID="txtDestino" runat="server" />
    <br />
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCopiar" runat="server" Text="Copiar" OnClick="btnCopiar_Click" />
</asp:Content>

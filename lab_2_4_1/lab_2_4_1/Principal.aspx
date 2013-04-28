<%@ Page Title="" Language="C#" MasterPageFile="~/Master Pages/MyMaster.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="lab_2_4_1.Principal" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label AssociatedControlID="txtOrigem" ID="lblOrigem" runat="server" Text="Texto  de Origem: "></asp:Label>
    <asp:TextBox ID="txtOrigem" runat="server" />
    <br />

    <asp:Label ID="lblDestino" AssociatedControlID="txtDestino" runat="server" Text="Texto de Destino: " />
    <asp:TextBox ID="txtDestino" runat="server" />
    <br />
    <br />

    <asp:Button ID="btnSalvar" runat="server" Text="Salvar" OnClick="btnSalvar_Click" />
    <asp:Button ID="btnCopiar" runat="server" Text="Copiar" OnClick="btnCopiar_Click"/>
      
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="wucLogin.ascx.cs" Inherits="lab2_4_2.wucLogin" %>
<asp:Label ID="lblMensagem" runat="server" />
<br />

<asp:Label ID="lblUsuario" AssociatedControlID="txtUsuario" runat="server" Text="Usuário: " />
<asp:TextBox ID="txtUsuario" runat="server" />
<br />

<asp:Label ID="lblSenha" AssociatedControlID="txtSenha" runat="server" Text="Senha: " />
<asp:TextBox ID="txtSenha" runat="server" TextMode="Password"/>
<br />

<asp:Button ID="btnLogin" runat="server" Text="Logar!" OnClick="btnLogin_Click" />



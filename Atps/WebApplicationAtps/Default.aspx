<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationAtps.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Login - Sistema de Gerenciamento de Qualidade
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="box-login">
					<h1 class="title">Login</h1>
					<div class="content"> 
                        <asp:label ID="lblResultado" runat="server"></asp:label>
						<div class="label">
                            <asp:Label ID="lblUsuario" AssociatedControlID="txtUsuario" runat="server">Usuário:</asp:Label>
                            <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
						</div>
						<div class="label">
                            <asp:Label ID="lblSenha" AssociatedControlID="txtSenha" runat="server">Senha:</asp:Label>
                            <asp:TextBox ID="txtSenha" runat="server" TextMode="Password"></asp:TextBox>
						</div>
					    <asp:Button ID="btnLogar" runat="server" Text="Logar" OnClick="btnLogar_Click"/>
					</div>
				</div>
</asp:Content>

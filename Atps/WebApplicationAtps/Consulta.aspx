<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage/Sistema.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="WebApplicationAtps.Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Consulta de Material - Sistema de Gerenciamento de Qualidade
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="search">
			<h1 class="title">Consulta de Material</h1>
            <asp:Label ID="lblRetorno" runat="server"></asp:Label>
			<div class="label">                
                <asp:Label ID="lblDepartamento" AssociatedControlID="ddlDepartamento"  runat="server">Departamento:</asp:Label>
				<asp:DropDownList 
                    runat="server" 
                    ID="ddlDepartamento" 
                    AutoPostBack="True" >
				</asp:DropDownList>
			</div>
						
			<div class="label">
                <asp:Label ID="lblTitulo" AssociatedControlID="txtTitulo"  runat="server">Título:</asp:Label>
                <asp:TextBox ID="txtTitulo" runat="server" SkinID="titulo" />
			</div>
						
			<div class="label">                
                <asp:Label ID="lblPeriodo" AssociatedControlID="txtPeriodo"  runat="server">Período:</asp:Label>
                <asp:TextBox ID="txtPeriodo" runat="server" SkinID="periodo" />
                
                <asp:Label ID="lblAte" AssociatedControlID="txtAte"  runat="server">até:</asp:Label>
                <asp:TextBox ID="txtAte" runat="server" SkinID="ate" />
			</div>
            <asp:Button ID="btnBuscar" Text="Buscar" runat="server" OnClick="btnBuscar_Click"/>
    </div>
	<div class="results">
        <asp:ListView runat="server" ID="lvMateriais">

            <LayoutTemplate>
                <table>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </LayoutTemplate>

            <EmptyItemTemplate>
                <p>Nenhum resultado encontrado!</p>
            </EmptyItemTemplate>

            <ItemTemplate>
                <tr>
				    <th>Departamento</th>
				    <td><%# Eval("Departamento.Descricao") %></td>
			    </tr>
			    <tr>
				    <th>Data</th>
				    <td><%# Eval("Data") %></td>
			    </tr>
			    <tr>
				    <th>Título</th>
				    <td><%# Eval("Titulo") %></td>
			    </tr>
			    <tr>
				    <th colspan="2" class="table-content">Conteúdo</th>
			    </tr>
			    <tr>
				    <td colspan="2">
					<%# Eval("Conteudo") %></td>
			    </tr>
            </ItemTemplate>
        </asp:ListView>				
	</div>
</asp:Content>
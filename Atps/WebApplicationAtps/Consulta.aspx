<%@ Page Title="" Language="C#" MasterPageFile="~/Sistema.Master" AutoEventWireup="true" CodeBehind="Consulta.aspx.cs" Inherits="WebApplicationAtps.Consulta" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    Consulta de Material - Sistema de Gerenciamento de Qualidade
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="search">
			<h1 class="title">Consulta de Material</h1>
			<div class="label">                
                <asp:Label ID="lblDepartamento" AssociatedControlID="ddlDepartamento"  runat="server">Departamento:</asp:Label>
				<asp:DropDownList ID="ddlDepartamento" runat="server"></asp:DropDownList>
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
        <asp:ListView runat="server"
            DataKeyNames="codigo" 
            ItemType="ATPS.Material"
            SelectMethod="GetData">

            <LayoutTemplate>
                <table>
                    <tr runat="server" id="itemPlaceholder"></tr>
                </table>
            </LayoutTemplate>

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
					    
				    <td><%# Eval("Conteudo") %></td>
				    </td>
			    </tr>
            </ItemTemplate>
        </asp:ListView>				
	</div>
</asp:Content>
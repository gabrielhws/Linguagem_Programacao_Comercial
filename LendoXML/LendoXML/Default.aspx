<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="LendoXML.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:ListView runat="server"
            DataKeyNames="title" ItemType="FileXML.Musica"
            SelectMethod="GetData">
        <LayoutTemplate>
            <table>
                <tr>
                    <th>Title</th>
                    <th>PubDate</th>
                    <th>Description</th>
                </tr>
                <tr runat="server" id="itemPlaceholder"></tr>                    
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td>
                    <a href='<%# Eval("link") %>'>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# Eval("title") %>' />
                    </a>
                </td>
                <td>
                    <asp:Label ID="lblPubDate" runat="server" Text='<%# Eval("pubDate") %>' />
                </td>
                <td>
                    <asp:Label ID="lblDescription" runat="server" Text='<%# Eval("description") %>' />
                </td>
            </tr>
        </ItemTemplate>
    </asp:ListView>
</body>
</html>

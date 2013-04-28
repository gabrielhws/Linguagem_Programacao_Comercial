<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CadastroCliente.aspx.cs" Inherits="Lab2._2.WebApplication.CadastroCliente" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblMessage" runat="server" />
            <br />
            <br />

            <asp:Label ID="lblName" runat="server" AssociatedControlID="txtName" Text="Name: "/>
            <asp:TextBox ID="txtName" runat="server"/>
            <br />

            <asp:Label ID="lblAge" runat="server" AssociatedControlID="txtAge" Text="Age: "/>
            <asp:TextBox ID="txtAge" runat="server" TextMode="Number" />
            <br />
            <br />

            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
        </div>
    </form>
</body>
</html>

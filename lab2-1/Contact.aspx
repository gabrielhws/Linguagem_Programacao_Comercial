<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="About" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblName" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        <br />

        <asp:Label ID="lblPhone" runat="server" Text="Phone: "></asp:Label>
        <asp:TextBox ID="txtPhone" runat="server" TextMode="Phone"></asp:TextBox>
        <br />

        
        <asp:Label ID="lblMail" runat="server" Text="Email: "></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" TextMode="Email"></asp:TextBox>
        <br />

        <asp:Label ID="lblGender" runat="server" Text="Gender: "></asp:Label>
        <asp:RadioButton ID="rbtnMale" GroupName="gnGender" runat="server" Text="Male" />
        <asp:RadioButton ID="rbtnFemale" GroupName="gnGender" runat="server" Text="Female" />

        <br />
        <asp:Button ID="btnSend" runat="server" Text="Send" />
    </div>
    </form>
</body>
</html>

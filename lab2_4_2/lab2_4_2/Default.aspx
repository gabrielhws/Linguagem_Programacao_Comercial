<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab2_4_2.Default" %>

<%@ Register Src="~/wucLogin.ascx" TagPrefix="uc1" TagName="wucLogin" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Scrum Easily</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:wucLogin runat="server" id="wucLogin1" />
    </div>
    </form>
</body>
</html>

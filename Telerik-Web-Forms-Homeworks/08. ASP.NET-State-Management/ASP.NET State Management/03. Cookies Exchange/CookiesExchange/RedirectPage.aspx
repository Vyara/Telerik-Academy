<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RedirectPage.aspx.cs" Inherits="CookiesExchange.RedirectPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button runat="server" ID="button" Text="Go Back" OnClick="Button_Click"/>
        <br />
        <asp:Literal runat="server" ID="Literal"></asp:Literal>
    </div>
    </form>
</body>
</html>

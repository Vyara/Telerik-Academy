<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SessionLog.Index" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="formMain" runat="server">
    <div>
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <asp:Button OnClick="Unnamed_Click" runat="server" Text="Submit" />

        <asp:Label ID="Label" runat="server"></asp:Label>
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="BooksXML.Books" %>


<%@ Import Namespace="System.Data" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:PlaceHolder ID="ControlPlaceHolder" runat="server"></asp:PlaceHolder>
        </div>
        <asp:XmlDataSource ID="BooksXmlDataSource" runat="server" DataFile="~/App_Data/books.xml"></asp:XmlDataSource>
    </form>
</body>
</html>

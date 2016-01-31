﻿<%@ Page Title="Home Page" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SumWebForms._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sum Numbers</title>
</head>
<body>
    <div class="well">
        <h1>Calculate Sum Of Two Numbers</h1>
        <form id="form" runat="server" class="jumbotron">
            <input id="sumA" type="number" runat="server" />
            <input id="sumB" type="number" runat="server" />
            <input id="submitBtn" value="Sum Numbers" type="submit" runat="server" onserverclick="OnSubmitButtonClick" />
            <div>
                <h3>Result:</h3>
                <asp:Label runat="server" ID="sumResult"></asp:Label>
            </div>
        </form>
    </div>
</body>
</html>

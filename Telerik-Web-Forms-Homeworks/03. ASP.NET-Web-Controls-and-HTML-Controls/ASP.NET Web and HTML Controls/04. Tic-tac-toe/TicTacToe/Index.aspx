﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="TicTacToe.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tic-tac-toe</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" />
    <link rel="stylesheet" href="site.css" />
</head>
<body>
    <form id="TicTacToe" runat="server">
        <div class="row">
            <div class="row col-lg-8 col-lg-offset-2">
                <h1>Tic Tac Toe</h1>
                <h3>
                    <asp:Label ID="Result" runat="server" Text="It's your turn"></asp:Label>
                </h3>
                <table>
                    <tr>
                        <td>
                            <asp:Button ID="Btn0" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="0" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn1" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="1" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn2" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="2" OnCommand="Click_Command" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn3" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="3" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn4" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="4" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn5" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="5" OnCommand="Click_Command" /></td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Button ID="Btn6" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="6" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn7" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="7" OnCommand="Click_Command" /></td>
                        <td>
                            <asp:Button ID="Btn8" Visible="true" runat="server" BackColor="#00ccff" CommandArgument="8" OnCommand="Click_Command" /></td>
                    </tr>
                </table>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-2.2.0.min.js" type="text/javascript"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>

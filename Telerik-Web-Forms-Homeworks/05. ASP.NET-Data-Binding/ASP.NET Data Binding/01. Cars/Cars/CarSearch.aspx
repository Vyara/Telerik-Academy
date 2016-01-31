<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarSearch.aspx.cs" Inherits="Cars.CarSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" />
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <div class="row">
        <div class="jumbotron centered col col-md-6 col-md-offset-3">
            <h2>A Simple Car Search Engine</h2>
        </div>
    </div>
    <form id="formMain" runat="server" class="col col-md-6 col-md-offset-3">
        <div>
            <div class="row">
            <asp:DropDownList runat="server" ID="ProducersList" DataTextField="Name" OnSelectedIndexChanged="ProducersList_SelectedIndexChanged" AppendDataBoundItems="True" AutoPostBack="true" CssClass="btn btn-default dropdown-toggle">
                <asp:ListItem>Select A Producer</asp:ListItem>
            </asp:DropDownList>
            <asp:DropDownList runat="server" ID="ModelsList" CssClass="btn btn-default dropdown-toggle">
            </asp:DropDownList>
            </div>
            <div class="row">
                <div class="well col-md-6">
                    <h3>Extras: </h3>
                    <asp:CheckBoxList ID="ExtrasCheckBoxList" runat="server" DataTextField="Name">
                    </asp:CheckBoxList>
                </div>
            </div>
            <div class="row">
                <div class="well col-md-6">
                    <h3>Engine: </h3>
                    <asp:RadioButtonList ID="EngineTypesRadioList" runat="server"></asp:RadioButtonList>
                </div>
            </div>
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" CssClass="btn btn-primary" OnClick="SubmitButton_Click" />
        </div>
            <div class="row">
    <asp:Literal runat="server" ID="ShowSubmitted">

    </asp:Literal>
        </div>
    </form>



</body>
</html>

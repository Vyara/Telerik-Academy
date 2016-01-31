<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="RandomGeneratedNumbers.Index" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Randon numbers</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" />
</head>
<body>
    <form id="formMain" runat="server">
        <div class="container">
            <h2>Generating Random Numbers</h2>
            <div class="well bs-component">
                <fieldset>
                    <legend>With HTML Server Controlls
                    </legend>
                    <div class="form-group">
                        <label for="From" class="col-lg-2 control-label">From: </label>
                        <div class="col-lg-10">
                            <input id="From" type="number" value="" class="form-control" style="background-color: wheat"  min="1" max="	
2147483647"
                                runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="To" class="col-lg-2 control-label">To: </label>
                        <div class="col-lg-10">
                            <input id="To" type="number" value="" class="form-control" style="background-color: wheat" min="1" max="	
2147483647"
                                runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10">
                            <input id="ButtonSubmit" type="button" runat="server" value="Generate" class="btn btn-default"
                                onserverclick="ButtonRandom_Click" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10">
                            <br />
                            <label runat="server" id="resultHTML" text="" visible="false"></label>
                        </div>
                    </div>
                </fieldset>
                <br />
                <br />
                <fieldset>
                    <legend>With Web server controls
                    </legend>
                    <div class="form-group">
                        <label for="FromWeb" class="col-lg-2 control-label">From: </label>
                        <div class="col-lg-10">
                            <asp:TextBox ID="FromWeb" class="form-control" BackColor="Wheat" type="number" in="1" max="	
2147483647"
                                runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="ToWeb" class="col-lg-2 control-label">To: </label>
                        <div class="col-lg-10">
                            <asp:TextBox ID="ToWeb" class="form-control" BackColor="Wheat" type="number" in="1" max="	
2147483647"
                                runat="server" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10">
                            <asp:Button ID="ButtonWebSubmit" runat="server" CssClass="btn btn-default"
                                Text="Generate" OnClick="ButtonRandomWeb_Click" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-lg-10">
                            <br />
                            <asp:Label ID="resultWeb" runat="server" Text="" Visible="false" />
                        </div>
                    </div>
                </fieldset>
            </div>
        </div>
    </form>
    <script src="https://code.jquery.com/jquery-2.2.0.min.js" type="text/javascript"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/js/bootstrap.min.js" type="text/javascript"></script>
</body>
</html>

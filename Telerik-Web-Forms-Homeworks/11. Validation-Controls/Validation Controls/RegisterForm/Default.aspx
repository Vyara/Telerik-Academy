<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="RegisterForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registration Form</h1>
            <asp:ValidationSummary runat="server" ForeColor="Red" />

            <asp:Label runat="server" Text="Username:"></asp:Label>
            <asp:TextBox ID="Username" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorUsername"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An username is required!"
                ControlToValidate="Username" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <br />

            <asp:Label runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                ControlToValidate="TextBoxPassword" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Password field is required!" ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label runat="server" Text="Confirm Password:"></asp:Label>
            <asp:TextBox ID="TextBoxRepeatPassword" runat="server" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatPassword"
                ControlToValidate="TextBoxRepeatPassword" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Repeat Password field is required!" ForeColor="Red" EnableClientScript="False" />

            <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
                ControlToCompare="TextBoxPassword"
                ControlToValidate="TextBoxRepeatPassword" Display="Dynamic"
                ErrorMessage="Password doesn't match!" ForeColor="Red" EnableClientScript="False">
            </asp:CompareValidator>
            <br />


            <asp:Label runat="server" Text="First name:"></asp:Label>
            <asp:TextBox ID="FirstName" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorFirstName"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="A first name is required!"
                ControlToValidate="FirstName" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <br />


            <asp:Label runat="server" Text="Last name:"></asp:Label>
            <asp:TextBox ID="LastName" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorLastName"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="A first name is required!"
                ControlToValidate="LastName" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <br />


            <asp:Label runat="server" Text="Age:"></asp:Label>
            <asp:TextBox ID="Age" runat="server" TextMode="Number" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorAge"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An age is required!"
                ControlToValidate="Age" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <asp:RangeValidator ID="RangeAgeValidator" runat="server"
                ForeColor="Red" Display="Dynamic"
                ErrorMessage="Age must be between 18 and 81"
                ControlToValidate="Age" EnableClientScript="false"
                MinimumValue="18" MaximumValue="81" Type="Integer">
            </asp:RangeValidator>
            <br />


            <asp:Label runat="server" Text="Email address:"></asp:Label>
            <asp:TextBox ID="TextBoxEmail" runat="server" TextMode="Email" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorEmail"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An email address is required!"
                ControlToValidate="TextBoxEmail" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidatorEmail"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="Email address is incorrect!"
                ControlToValidate="TextBoxEmail" EnableClientScript="False"
                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}">
            </asp:RegularExpressionValidator>
            <br />

            <asp:Label runat="server" Text="Billing address:"></asp:Label>
            <asp:TextBox ID="TextBoxAddress" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorTextBoxAddress"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An address is required!"
                ControlToValidate="TextBoxAddress" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <br />


            <asp:Label runat="server" Text="Phone:"></asp:Label>
            <asp:TextBox ID="TextBoxPhone" runat="server" />
            <asp:RequiredFieldValidator
                ID="RequiredFieldValidatorPhone"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="An phone is required!"
                ControlToValidate="TextBoxPhone" EnableClientScript="false">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="PhoneValidator" runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="Phone can only contain digits" ControlToValidate="TextBoxPhone" EnableClientScript="false"
                ValidationExpression="\d+">
            </asp:RegularExpressionValidator>
            <br />

            <asp:Label runat="server" Text="I Agree with the terms and conditions of this site"></asp:Label>
            <asp:CheckBox runat="server" ID="RequiredTickValidator" />
            <asp:CustomValidator runat="server" ID="CheckBoxRequired" EnableClientScript="false"
                OnServerValidate="CheckBoxRequired_ServerValidate"
                ClientValidationFunction="CheckBoxRequired_ClientValidate" ForeColor="Red" ErrorMessage="You must select this box to proceed."></asp:CustomValidator>


            <asp:Button ID="ButtonSubmit" runat="server" CssClass="btn btn-group-sm btn-success" Text="Submit"
                OnClick="ButtonSubmit_Click" />
            <br />
            <asp:Label ID="LabelMessage" runat="server" Text="Label" Visible="false" ForeColor="Green"></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CashingDataWebForms._Default" %>

<%@ Register Src="~/UserControl.ascx" TagPrefix="uc1" TagName="UserControl" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

   <uc1:UserControl runat="server" ID="UserControl" />
    
    <p>About Page is cached for an hour</p>

</asp:Content>
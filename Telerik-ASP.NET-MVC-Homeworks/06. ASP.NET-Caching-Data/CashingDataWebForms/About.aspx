<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="CashingDataWebForms.About" %>

<%@ OutputCache CacheProfile="OneHourLong" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <header>
        <h1><%= DateTime.Now.ToLongTimeString() %></h1>
    </header>
</asp:Content>

<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UserControl.ascx.cs" Inherits="CashingDataWebForms.UserControl" %>
<%@ OutputCache Duration="3" VaryByParam="none" Shared="true" %>

<h2><%= DateTime.Now.ToLongTimeString() %></h2>
<h3>Caching User Control!</h3>
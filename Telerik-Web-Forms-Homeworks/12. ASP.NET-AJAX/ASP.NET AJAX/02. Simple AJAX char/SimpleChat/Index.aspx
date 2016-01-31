<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SimpleChat.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Simple Chat</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.6/css/bootstrap-theme.min.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager" runat="server"></asp:ScriptManager>

            <asp:ListView runat="server" ID="ChatListView" ItemType="SimpleChat.Models.Message" InsertItemPosition="LastItem" DataKeyNames="Id" OnItemInserting="ChatListView_ItemInserting">
                <LayoutTemplate>

                    <asp:UpdatePanel ID="AjaxChatUpdatePanel" runat="server">
                        <Triggers>
                            <asp:AsyncPostBackTrigger EventName="Tick" ControlID="TimerChatRefresh" />
                        </Triggers>
                        <ContentTemplate>
                            <div id="itemPlaceHolder" runat="server"></div>
                        </ContentTemplate>
                    </asp:UpdatePanel>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="message">
                        <%#: Item.Username %>:
                        <%#: Item.Text %>
                    </div>
                </ItemTemplate>
                <InsertItemTemplate>

                </InsertItemTemplate>
            </asp:ListView>
            <div>
                        <asp:Label runat="server" AssociatedControlID="tb_Username" ID="UsernameLabel" Text="Username: " />
                        <asp:TextBox runat="server" ID="tb_Username" Text='<%#Bind("Username") %>'></asp:TextBox>

                        <asp:Label runat="server" AssociatedControlID="tb_Message" ID="MessageLabel" Text="Message: " />
                        <asp:TextBox runat="server" ID="tb_Message" Text='<%#Bind("Text") %>'></asp:TextBox>
                    </div>
                    <asp:LinkButton ID="InsertButton" CssClass="btn btn-default" runat="server"
                        CommandName="Insert" Text="Insert" OnCommand="InsertButton_Command" />

            <asp:Timer ID="TimerChatRefresh" runat="server" Interval="500" />

        </div>
    </form>
</body>
</html>

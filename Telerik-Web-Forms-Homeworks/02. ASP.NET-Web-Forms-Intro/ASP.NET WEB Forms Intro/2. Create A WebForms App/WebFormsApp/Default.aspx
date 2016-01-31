<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebFormsApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <div class="jumbotron">
        <h1>WebForms Info</h1>
        <h4>Current Assembly Location:<asp:Label ID="LabelAssembly" runat="server"></asp:Label></h4>        
    </div>
     <div class="well">
        <h3 class="lead">Hello, those are the purposes of the generated files:</h3>
        <p>
            App data:  Acts as a local database and stores data in that folder.
        </p>
        <p>
            App start:  Holds base app configurations, like Bundle, Identity, Route configs and Startup.Auth. 
        </p>
        <p>
            Content: contains css files for the app.
        </p>
        <p>
            Fonts: contains some fonts for the client side of the app.
        </p>
        <p>
            Scripts: Holds javascript files needed for the client side.
        </p>
        <p>
            There are 3 default aspx pages - About, Default and Contact, those are used for creating a basic app.
        </p>
        <p>
            Site master is a master page, from which all other pages inherit anmd reuse layout.
        </p>
        <p>
            Global.asax is the code that executes on startup - it calls all the classes in App_Start and configurates them.
        </p>
        <p>
            Web config: used to configurate the app (has a debug and release mode). Usually information about connection strings, access rights to different routs, route maps etc.
        </p>
    </div>
    <hr />
    <div class="well">
        <h3>Code behind</h3>
        <p>
           It is a separate file for the code, which contains declarations for the server controls, and contains all the event handlers and such. The aspx file then derives from this class for the final page.
        </p>
    </div>

</asp:Content>

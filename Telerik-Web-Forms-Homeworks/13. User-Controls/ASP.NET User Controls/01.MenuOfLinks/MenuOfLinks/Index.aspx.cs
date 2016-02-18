namespace MenuOfLinks
{
    using System;
    using System.Web.UI;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MenuOption[] options = 
                {
                         new MenuOption("first", "FirstPage.aspx"),
                         new MenuOption("second", "SecondPage.aspx"),
                         new MenuOption("third", "ThirdPage.aspx"),
                         new MenuOption("fourth", "FourthPage.aspx")
            };

            LinkMenu.FontFamily = "Consolas";
            LinkMenu.FontColor = "#FF6600";
            LinkMenu.DataSource = options;
            LinkMenu.DataBind();
        }
    }
}
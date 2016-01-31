namespace _01.ShowClientInfo
{
    using System;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Label.Text = Request.UserAgent + "<br/>";
            this.Label.Text += Request.UserHostAddress.ToString().Trim();
        }
    }
}
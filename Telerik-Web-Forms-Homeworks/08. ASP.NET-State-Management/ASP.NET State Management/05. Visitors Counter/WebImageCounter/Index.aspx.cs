namespace WebImageCounter
{
    using System;
    using System.Web.UI;

    public partial class Index : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.Controls.Add(new LiteralControl("<img src=\"ImageForm.aspx\" />"));
        }
    }
}
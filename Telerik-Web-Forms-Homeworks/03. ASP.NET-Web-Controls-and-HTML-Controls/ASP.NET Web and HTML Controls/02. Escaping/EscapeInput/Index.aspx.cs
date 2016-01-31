namespace EscapeInput
{
    using System;

    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void DisplayButton_Click(object sender, EventArgs e)
        {
            string enteredText = RawText.Text;
            ResultEscaped.Text = Server.HtmlEncode(enteredText);
            ResultEscaped.Visible = true;
        }
    }
}